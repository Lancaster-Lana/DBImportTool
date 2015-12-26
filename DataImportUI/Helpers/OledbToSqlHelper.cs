using System;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms.VisualStyles;
using DataImportTool.Controls;
using DataImportTool.Tools;

namespace oledb_sql
{
	public class OledbToSqlHelper
	{

		/// <summary>
		/// Executes BulkCopy for OleDB data to SQL Server
		/// </summary>
		/// <param name="oleDbConnectionString">The OleDB connection string</param>
		/// <param name="oleDbSQL">The SQL code to retrive OleDB data</param>
		/// <param name="sqlConnectionString">The SQL Server connection string</param>
		/// <param name="sqlTableName">The SQL Server destination table</param>
		public static string GenerateImportScript_OleDBtoSqlServer(string oleDbConnectionString,
																			string sourceTbl, string targetTbl,
																			Dictionary<string, string> PKsMappings, Dictionary<ColumnExpression, string> columnsMappings)
		{
			var scriptBuilder = new StringBuilder();

			using (var oleDbConnection = new OleDbConnection(oleDbConnectionString))
			{
				oleDbConnection.Open();

				string oleDbSQL = string.Format("SELECT * FROM [{0}]", sourceTbl);

				using (var oleDBCommand = new OleDbCommand(oleDbSQL, oleDbConnection))
				{
					using (var oleReader = oleDBCommand.ExecuteReader())
					{
						if (oleReader.HasRows)
							while (oleReader.Read())
							{
								bool isFirstParam = true;
								bool isFirstPartPK = true;

								string valuesList = string.Empty;
								string parametersList = string.Empty;
								string paramsValuesString = string.Empty;
								string whereClause = "";//" WHERE  ";

								foreach (var mapping in columnsMappings.Where(c => !string.IsNullOrWhiteSpace(c.Key.ColumnName)))
								{
									ColumnExpression sourceColumnExpr = mapping.Key;//NOTE: source table column value can be mapped as a part to target colunm data (be splitted by separator like : ',' ';' ) 
									string sourceColumn = sourceColumnExpr.ColumnName;

									string targetColumn = mapping.Value;
									bool isPartPK = PKsMappings.Keys.Contains(sourceColumn); // use only in WHERE clause

									//calculate source column (or its part) value
									object sourceColumnValue = oleReader[sourceColumn];
									object newValue = ColumnExpression.GetExpressionResult(sourceColumnExpr, sourceColumnValue);

									//1. Create update script for Target DB
									//bool isNuewValueDBNull = newValue is System.DBNull;

									if (!isPartPK)
									{
										//TODO: format specific types values before update
										if (newValue is DateTime)
											newValue = ((DateTime)newValue).ToString("yyyymmdd");

										if (!isFirstParam)
										{
											parametersList += ", ";
											paramsValuesString += ", ";
											valuesList += ", ";
										}

										parametersList += string.Format(" [{0}] ", targetColumn);
										valuesList += string.Format(" '{0}'", newValue);
										paramsValuesString += string.Format(" [{0}] ='{1}' ", targetColumn, newValue);

										isFirstParam = false;
									}
									//2. create WHERE block
									else
									{
										var PKValue = sourceColumnValue;

										if (!isFirstPartPK) whereClause += " AND ";
										whereClause += string.Format(" [dbo].[{0}].[{1}]='{2}' ", targetTbl, targetColumn, PKValue);

										isFirstPartPK = false;
									}
								}

								//3. Append parameters and WHERE block to update\insert block
								scriptBuilder.Append(string.Format(
												"IF NOT EXISTS (SELECT 1 FROM [dbo].[{0}] WHERE {4} ) "
											+ " BEGIN  INSERT INTO [dbo].[{0}] ({1}) VALUES({2}) END"
											+ " ELSE BEGIN  UPDATE [dbo].[{0}] WITH(ROWLOCK) SET {3}  WHERE {4} END", targetTbl, parametersList, valuesList, paramsValuesString, whereClause));

								scriptBuilder.AppendLine();
							}
					}
				}
			}
			return scriptBuilder.ToString();
		}

		/// <summary>
		///DIRECT Import data from Excel to SQLServer 
		/// </summary>
		/// <param name="sourceDbConnectionString"></param>
		/// <param name="oleDbSQL">dynamic sql query to select from Excel file</param>
		/// <param name="sqlConnectionString">Target SQL Server</param>
		/// <param name="sqlTableName">Destination table [sqlTableName] </param>
		public static void DirectImportDataFromOleDbToSqlServer(string sourceDbConnectionString, string oleDbSQL,
																																string sqlConnectionString, string sqlTableName,
																																Dictionary<ColumnExpression, string> columnsMappings)
		{
			using (var oleDbConnection = new OleDbConnection(sourceDbConnectionString))
			{
				oleDbConnection.Open();

				DbCommand command = new OleDbCommand(oleDbSQL, oleDbConnection);

				using (var oleDbReader = command.ExecuteReader())
				{
					//var id= reader.GetGuid();

					//open TARGET DB connection
					using (var sqlConnection = new SqlConnection(sqlConnectionString))
					{
						sqlConnection.Open();

						using (var bulkCopy = new SqlBulkCopy(sqlConnection))
						{
							bulkCopy.DestinationTableName = sqlTableName;

							//Do columns mappings
							foreach (var mapping in columnsMappings)
							{
								// Set up the column mappings by name.
								SqlBulkCopyColumnMapping mapID = new SqlBulkCopyColumnMapping(mapping.Key.ColumnName, mapping.Value);
								bulkCopy.ColumnMappings.Add(mapID);
							}

							//RUN import
							try
							{
								bulkCopy.WriteToServer(oleDbReader);
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
							}
							finally
							{
								// Close the SqlDataReader. The SqlBulkCopy  object is automatically closed at the end of the using block.
								oleDbReader.Close();
							}
						}
					}
				}
			}
		}


		/// <summary>
		/// Formats value for CSV output
		/// </summary>
		/// <param name="value">The value to output</param>
		/// <param name="delimiter">The CSV column delimiter</param>
		/// <returns>
		/// The formatted value.
		/// </returns>
		/// <remarks>
		/// Function qoutes string values which contains delimiter or qoutes.
		/// </remarks>
		static Object FormatValueForCSV(Object value, string delimiter)
		{
			switch (value.GetType().Name)
			{
				case "String":
					if (value.ToString().IndexOf('"') >= 0)
					{
						return '"' + value.ToString().Replace(@"""", @"""""") + '"';
					}
					if (value.ToString().IndexOf(delimiter, System.StringComparison.Ordinal) >= 0)
					{
						return '"' + value.ToString() + '"';
					}
					return value.ToString();
				default:
					return value;
			}

		}

		/// <summary>
		/// Expands a full path for a connection string data source.
		/// </summary>
		/// <param name="connectionString">The connection string</param>
		/// <returns>
		/// The connection string with a full path of a data source.
		/// </returns>
		/// <remarks>
		/// The OleDB standard dictates a use of a full path for a data source.
		/// </remarks>
		static string ExpandConnectionStringFileName(string connectionString)
		{
			const string term = "Data Source=";

			int index = connectionString.IndexOf(term);
			if (index < 0)
				return connectionString;

			string dataSource = connectionString.Substring(index + term.Length,
					connectionString.IndexOf(";", index + term.Length) - index - term.Length);

			if (!File.Exists(dataSource))
				return connectionString;

			string expandedDataSource = Path.GetFullPath(dataSource);

			// Console.WriteLine("DataSource expanded to {0}", expandedDataSource);

			connectionString.Replace(term + dataSource, term + expandedDataSource);

			return connectionString;

		}

		/// <summary>
		/// Outputs OleDB data to the console using CSV format
		/// </summary>
		/// <param name="oleDbConnectionString">The OleDB connection string</param>
		/// <param name="oleDbSQL">The SQL code to retrive OleDB data</param>
		/// <param name="delimiter">The CSV column delimiter</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
		static void OleDBtoCSV(string oleDbConnectionString, string oleDbSQL, string delimiter)
		{
			oleDbConnectionString = ExpandConnectionStringFileName(oleDbConnectionString);

			var oleDbConnection = new OleDbConnection(oleDbConnectionString);
			try
			{
				oleDbConnection.Open();
				var command = new OleDbCommand(oleDbSQL, oleDbConnection);
				try
				{
					OleDbDataReader reader = command.ExecuteReader();
					try
					{
						Console.Write("{0}", reader.GetName(0));
						for (int i = 1; i < reader.FieldCount; i++)
						{
							Console.Write("{1}{0}", reader.GetName(i), delimiter);
						}
						Console.WriteLine();

						while (reader.Read())
						{
							Console.Write("{0}", reader.GetValue(0));
							for (int i = 1; i < reader.FieldCount; i++)
							{
								Console.Write("{1}{0}", FormatValueForCSV(reader.GetValue(i), delimiter), delimiter);
							}
							Console.WriteLine();
						}
					}
					finally
					{
						reader.Close();
					}
				}
				finally
				{
					command.Dispose();
				}
			}
			finally
			{
				oleDbConnection.Close();
			}
		}
	}
}

////OR use recordset to move by table record 
//var conn = new ADODB.Connection();
//string connString = "Data Source=[server]; Initial Catalog=[initial]; User ID=[username]; Password=[password]";
//	dbName = openDBConn("YOURDATABASE", "YourTable");
//	var dbResults = CreateObject("ADODB.Recordset");
//	dbResults = dbName.Execute("SELECT * FROM YOURDATABASE");
//	While(!dbResults.EOF)
//{
//		 'Do Something'
//		 dbResults.MoveNext()
//}
/*
		/// <summary>
		///Usage cursor in ADO.NET to create update script (to import data from Excel to SQLServer) 
		/// </summary>
		public static string GenerateUpdateScript_ADODBCursor(string connOleDbString,
																			string sourceTbl, string sourcrPKColumn,
																			string targetTbl, string targetPKColumn,
																			Dictionary<string, string> columnsMappings)
		{
			StringBuilder scriptBuilder = new StringBuilder();
	//string sourceTbl = txtSourceTable.Text;
		//string connOleDbString = _oleDBConnString;//"Provider=SQLOLEDB;Data Source=[server];Initial Catalog=[database];";//
		var conn = new ADODB.Connection();
		var rs = new ADODB.RecordsetClass();

		try
		{

			conn.Open(connOleDbString);//, [user], [pwd],0);

			string sql = string.Format("SELECT * FROM {0}", sourceTbl);
			rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, -1);

				
			//Read 
			while (rs.EOF == false)
			{
				scriptBuilder.AppendLine(string.Format(" 'UPDATE [dbo].[{0}] WITH(ROWLOCK) SET '", targetTbl));

				string ID = rs.GetString(sourcrPKColumn);
				foreach (var mapping in columnsMappings)
				{
					string sourceColumn = mapping.Key;
					string targetColumn = mapping.Value;

					var newValue = rs.GetString(sourceColumn);
					scriptBuilder.AppendLine(string.Format(" + '[dbo].[{0}].[{1}] ='{2}' ", targetTbl, targetColumn, newValue));
				}
				scriptBuilder.AppendLine(string.Format(" + ' WHERE [dbo].[{0}].[{1}]='{2}' ; ", targetTbl, targetPKColumn, ID));
					

				//rs.Update("field_name", [new_value]);
				rs.MoveNext();
			}
		}
		catch (Exception e)
		{
			MessageBox.Show("Error" + e.Message);
		}
		finally
		{
			conn.Close();
		}

			return scriptBuilder.ToString();
		}
*/