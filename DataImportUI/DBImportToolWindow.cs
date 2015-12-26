using DataImportTool.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataImportUI
{
	public partial class DBImportToolWindow : Form
	{
		//Connection strings to  OLE DB databases		http://www.connectionstrings.com/access/
		private const string EXCEL_CONNECTION_STRING_FORMAT = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
		private const string ACCESS_CONNECTION_STRING_FORMAT = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id=admin;Password=;";
		private const string CSV_CONNECTION_STRING_FORMAT = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='{0}'; Extended Properties=\"Text; HDR=Yes; FMT=Delimited\";";
		private const string TEXT_CONNECTION_STRING_FORMAT = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"text;HDR=Yes;FMT=Fixed\";";
		//private const string TEXT_CONNECTION_STRING_FORMAT_ODBC = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq={0};Extensions=asc,csv,tab,txt;;";
		// TextReader = "Data Source='C:\MyFolder';Delimiter=',';Has Quotes=True;Skip Rows=0;Has Header=True;Comment Prefix='';Column Type=String,String,String,Int32,Boolean,String,String;Trim Spaces=False;Ignore Empty Lines=True;"

		#region Properties

		private DbConnection _sourceDbConnection;
		public DbConnection SourceDbConnection
		{
			get { return _sourceDbConnection; }
			set
			{
				_sourceDbConnection = ucImportMapping.SourceDbConnection = value;
			}
		}

		private DbConnection _targetDbConnection;
		public DbConnection TargetDbConnection
		{
			get { return _targetDbConnection; }
			set
			{
				_targetDbConnection = ucImportMapping.TargetDbConnection = value;
			}
		}

		private readonly DataView sourceDataView = null;

		private readonly DataView targetDataView = null;

		#endregion

		#region Ctor

		public DBImportToolWindow()
		{
			InitializeComponent();

			//Init filtering views
			sourceDataView = new DataView();
			sourceDataView.AllowEdit = false;
			sourceDataView.AllowNew = false;
			sourceDataView.AllowDelete = false;
			gridSourceTable.DataSource = sourceDataView;
			gridSourceTable.DataError += gridTable_DataError;

			targetDataView = new DataView();
			targetDataView.AllowEdit = false;
			targetDataView.AllowNew = false;
			targetDataView.AllowDelete = false;
			gridTargetTable.DataSource = targetDataView;
			gridTargetTable.DataError += gridTable_DataError;
		}

		/// <summary>
		/// TODO:
		/// </summary>
		~DBImportToolWindow()
		{
			if (SourceDbConnection != null)
				SourceDbConnection.Dispose();
			if (TargetDbConnection != null)
				TargetDbConnection.Dispose();

			gridTargetTable.DataError -= gridTable_DataError;
		}

		#endregion

		#region Methods & Handlers

		#region Source DB

		private string _sourceDBConnString;

		private void btnOpenSourceDBFile_Click(object sender, EventArgs e)
		{
			using (var dialog = new OpenFileDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = txtSourceDBFile.Text = dialog.FileName;
					string fileExt = dialog.FileName.Split('.')[1];
					if (fileExt.StartsWith("xls"))
						_sourceDBConnString = String.Format(EXCEL_CONNECTION_STRING_FORMAT, filePath);
					else if (fileExt == "mdb")
						_sourceDBConnString = String.Format(ACCESS_CONNECTION_STRING_FORMAT, filePath);
					else if (fileExt == "csv")
						_sourceDBConnString = String.Format(CSV_CONNECTION_STRING_FORMAT, System.IO.Path.GetDirectoryName(filePath));
					else if (fileExt == "txt")
						_sourceDBConnString = String.Format(TEXT_CONNECTION_STRING_FORMAT, filePath);
					//else if (fileExt == "mdf")
					//    _sourceDBConnString = String.Format(SQL_CONNECTION_STRING_FORMAT, filePath);

					(new ToolTip()).SetToolTip(txtSourceDBFile, _sourceDBConnString);

					//Get Data from source Db
					FillSourceDbData(_sourceDBConnString, fileExt);
				}
			}
		}

		private void FillSourceDbData(string sourceDBConnString, string dbExt)
		{
			//1. request to get data tables

			IList<string> sourceDBTablesNames = new List<string>();

			//open OleDB (notSQLConnection) to read data from Excel
			//using (var oleDbConn = new OleDbConnection(oleDBConnString))
			//{
			if (dbExt == "mdf")
				SourceDbConnection = new SqlConnection(sourceDBConnString);
			else
				SourceDbConnection = new OleDbConnection(sourceDBConnString);

			//Get all existing tables names
			sourceDBTablesNames = SourceDbConnection.GetDbTablesNames();//GetDataFromDB(SourceDbConnection, ref oleDbTables);

			//2. fill data to controls;
			cmbSourceTable.DataSource = sourceDBTablesNames;
			cmbSourceTable.Update();
		}

		private void cmbSourceTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			sourceDataView.Table = null;

			string selectedTableName = Convert.ToString(cmbSourceTable.SelectedItem);
			if (string.IsNullOrEmpty(selectedTableName)) return;

			DataTable sourceTable = SourceDbConnection.GetDbTable(selectedTableName, true);
			sourceTable.TableName = selectedTableName;

			//indicate the current source table
			sourceDataView.Table = sourceTable;
			txtSourceTablePK.Text = sourceTable != null ? sourceTable.Columns[0].ColumnName : "";
		}

		#endregion

		#region Target DB

		private void btnConnectSQLSerer_Click(object sender, EventArgs e)
		{
			using (var dialog = new LoginForm())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					if (!dialog.IsConnected)
						MessageBox.Show("Cannot connect to DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
					{
						TargetDbConnection = dialog.DBConnection;
						if (TargetDbConnection.Verify())
						{
							FillTargetDbData(TargetDbConnection);
							//select all the tables
							//var targetTablesNames = dbConn.GetDbTables();
							//targetDbTables.AddRange(targetTablesNames.Select(oleDbConn.GetDbTable));
						}
					}
				}
			}
		}

		private void FillTargetDbData(DbConnection dbConn)
		{
			txtSQLServerConnStr.Text = dbConn.ConnectionString;

			//1. SqlServer request to get data tables
			var targetTablesNames = dbConn.GetDbTablesNames();//GetDataFromDB(dbConn, ref tables);

			//2. fill data to controls;
			cmbTargetTable.DataSource = targetTablesNames;//tables;
			//cmbTargetTable.DisplayMember = "TableName";
			cmbTargetTable.Update();
		}

		private void cmbTargetTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			targetDataView.Table = null;

			string selectedTableName = cmbTargetTable.SelectedItem.ToString();
			if (string.IsNullOrEmpty(selectedTableName)) return;

			DataTable targetTable = TargetDbConnection.GetDbTable(selectedTableName, true);
			targetTable.TableName = selectedTableName;
			targetDataView.Table = targetTable;

			txtTargetTablePK.Text = targetTable != null ? targetTable.Columns[0].ColumnName : "";
		}

		#endregion

		private void gridTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			//TODO:
		}

		#endregion
	}
}