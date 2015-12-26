using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DataImportTool.Helpers
{
	internal static class DBExtender
	{
		public static bool Verify(this DbConnection dbConn)
		{
			try
			{
				if (dbConn != null && dbConn.State != ConnectionState.Open)
					dbConn.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}

			return true;
		}

		public static List<string> GetDbTablesNames(this DbConnection dbConn)
		{
			var result = new List<string>();
			DataTable tables = null;

			if (dbConn.Verify())
			{
				if (dbConn is SqlConnection || dbConn is OdbcConnection)
					tables = dbConn.GetSchema("Tables");
				else if (dbConn is OleDbConnection)
					tables = ((OleDbConnection)dbConn).GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

				if (tables != null)
					result.AddRange(tables.Rows.Cast<DataRow>()
												.Select(row => row["TABLE_NAME"].ToString())
												.Where(tblName => !tblName.StartsWith("MSys")));
			}
			return result;
		}

		public static List<DataColumn> GetDbTableColumns(this DbConnection dbConn, string tableName)
		{
			var result = new List<string>();
			var mapper = new List<KeyValuePair<string, DataColumn>>();
			var selectSQL = string.Format("SELECT * FROM [{0}] WHERE 1=0", tableName);//dbConn is OleDbConnection ? 
			//: string.Format("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{0}'", tableName);

			//var table = dbConn.GetDbTable(tableName);
			var table = RunDynamicSelectSQLQuery(dbConn, selectSQL);
			foreach (DataColumn col in table.Columns)
			{
				result.Add(col.ColumnName);
				mapper.Add(new KeyValuePair<string, DataColumn>(col.ColumnName, col));
			}
			return table.Columns.Cast<DataColumn>().ToList();
		}

		public static string GetDBTablePrimaryKey(this DbConnection dbConn, string tableName)
		{
			//string tablePKQuery = string.Format( "SELECT Col.Column_Name from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab,  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col  WHERE Col.Constraint_Name = Tab.Constraint_Name AND Col.Table_Name=Tab.Table_Name AND Constraint_Type='PRIMARY KEY' AND Col.Table_Name='{0}'", tableName);
			////string tablePKQuery = string.Format("SELECT * FROM sys.objects WHERE type = 'PK' AND  object_id = OBJECT_ID ('{0}')", tableName);
			////string tablePKQuery = string.Format("SELECT column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 AND table_name = '{0}'", tableName);
			//DataTable resultPKTable = RunDynamicSelectSQLQuery(dbConn, tablePKQuery);
			//return resultPKTable != null ?  resultPKTable.Rows[0][0].ToString(): "";

			DataTable schemaIndexes = dbConn.GetSchema("Indexes");

			return schemaIndexes.Rows.Cast<DataRow>()
				.Where(row => row.Field<string>("TABLE_NAME").Equals(tableName))
				.Select(row => row.Field<string>("COLUMN_NAME")).FirstOrDefault();
		}

		public static DataTable GetDbTable(this DbConnection dbConn, string tableName, bool removeEmptyRows = false)
		{
			DataTable table = new DataTable(tableName);
			string selectSQL = string.Format("SELECT * FROM [{0}]", tableName);

			if (dbConn.Verify())
			{
				using (var cmd = dbConn.CreateCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = selectSQL;

					DbDataAdapter dbAdapter = null;
					if (dbConn is SqlConnection)
						dbAdapter = new SqlDataAdapter((SqlCommand)cmd);
					if (dbConn is OleDbConnection)
						dbAdapter = new OleDbDataAdapter((OleDbCommand)cmd);
					if (dbConn is OdbcConnection)
						dbAdapter = new OdbcDataAdapter((OdbcCommand)cmd);
					dbAdapter.Fill(table);
				}
			}

			//string PK = GetDBTablePrimaryKey(dbConn, tableName);

			if(removeEmptyRows)
				table = table.Rows.Cast<DataRow>().Where(row => row.Field<object>(0) != null).CopyToDataTable();//exclude rows with PK = NULL
			return table;
		}


		public static DataTable RunDynamicSelectSQLQuery(this DbConnection dbConn, string selectSQL)
		{
			var table = new DataTable();

			if (dbConn.Verify())
			{
				using (var cmd = dbConn.CreateCommand())
				{
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = selectSQL;

					DbDataAdapter dbAdapter = null;
					if (dbConn is SqlConnection)
						dbAdapter = new SqlDataAdapter((SqlCommand)cmd);
					if (dbConn is OleDbConnection)
						dbAdapter = new OleDbDataAdapter((OleDbCommand)cmd);
					if (dbConn is OdbcConnection)
						dbAdapter = new OdbcDataAdapter((OdbcCommand)cmd);
					dbAdapter.Fill(table);
				}
			}
			return table;
		}

		/// <summary>
		/// Run update or insert script
		/// </summary>
		/// <param name="dbConn"></param>
		/// <param name="sqlScript">update or insert script</param>
		/// <param name="columnWithValue"></param>
		/// <returns></returns>
		public static string ExecNonSQLQuery(this DbConnection dbConn, string sqlScript, Dictionary<string, object> columnWithValue = null)
		{
			try
			{
				if (dbConn.Verify())
				{
					using (var cmd = dbConn.CreateCommand())
					{
						cmd.CommandType = CommandType.Text;//StoredProcedure;
						cmd.CommandText = sqlScript;

						if (columnWithValue != null)
						{
							if (dbConn is SqlConnection)
							{
								var sqlCommand = (SqlCommand)cmd;
								//sqlcmd.Parameters.AddWithValue("SalesEffectiveDates", "");	
								foreach (var mapping in columnWithValue)
								{
									sqlCommand.Parameters.AddWithValue(mapping.Key, mapping.Value);
								}
							}
							if (dbConn is OleDbConnection)
							{
								var oledbCommand = (OleDbCommand)cmd;
								foreach (var mapping in columnWithValue)
								{
									oledbCommand.Parameters.AddWithValue(mapping.Key, mapping.Value);
								}
							}
							if (dbConn is OdbcConnection)
							{
								var odbcCommand = (OdbcCommand)cmd;
								foreach (var mapping in columnWithValue)
								{
									odbcCommand.Parameters.AddWithValue(mapping.Key, mapping.Value);
								}
							}
						}

						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

			return ""; //error string
		}
	}
}
