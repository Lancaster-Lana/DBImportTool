using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Threading;

namespace DataImportUI
{

	public partial class LoginForm : Form
	{
		#region CONNECTION STRINGS CONSTANTS

		public const string SQLSERVER_WINDOWSAUTH_CONNECTION_STRING =
			"Data Source='{0}';Initial Catalog='{1}';TRUSTED_CONNECTION=True;";

		public const string SQLSERVER_SQLAUTH_CONNECTION_STRING =
			"Data Source='{0}';Initial Catalog='{1}';Persist Security Info=True;User ID='{2}'; Password='{3}';";

		//Excel 1997-2003  with .xls extention
		public const string OLEDB_EXCELOLD_CONNECTION_STRING =
			"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\";";

		//file with .xlsx extention
		public const string OLEDB_EXCEL20xx_CONNECTION_STRING =
			"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

		//file with .xlsm extention
		public const string OLEDB_EXCELMACROS_CONNECTION_STRING =
			"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Macro;HDR=YES\";";

		//file with .mdb extention
		public const string OLEDB_MSACCESS_CONNECTION_STRING =
			"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

		//ASE, Oracle DB connections
		public const string ODBC_CONNECTION_STRING =
			"Data Source='{0}';Initial Catalog='{1}';Persist Security Info=True;User ID='{2}'; Password='{3}';";

		#endregion

		#region Properties

		public bool IsConnected = false;

		public DbConnection DBConnection { get; private set; }

		private DataRow SelectedProviderRow;

		#endregion

		public LoginForm()
		{
			InitializeComponent();
		}

		#region Handlers

		private void LoginForm_Load(object sender, EventArgs e)
		{
			//Load supported providers
			cmbProvider.DataSource = SettingsManager.ProvidersTable; //.ProvidersListOnHost;
			cmbProvider.DisplayMember = "InvariantName"; //"Description";
			cmbProvider.ValueMember = "AssemblyQualifiedName";

			cmbProvider.Refresh();
		}

		private void rbConnectionType_CheckedChanged(object sender, EventArgs e)
		{
			string connectionStr = string.Empty;

			btnChooseDB.Visible = !rbSQLServerConnection.Checked;
			grpLogin.Visible = grpAuthType.Visible = rbSQLServerConnection.Checked;

			if (rbSQLServerConnection.Checked)
			{
				connectionStr = rbSQLServerAuth.Checked ? SQLSERVER_SQLAUTH_CONNECTION_STRING : SQLSERVER_WINDOWSAUTH_CONNECTION_STRING;
			}
			else if (rbOLEDB.Checked)
			{
				connectionStr = OLEDB_EXCEL20xx_CONNECTION_STRING;
			}
			else if (rbODBC.Checked)
			{
				connectionStr = ODBC_CONNECTION_STRING;
			}
			else if (rbDBFactory.Checked)
				CreateDBFactoryConnection(connectionStr);

			txtConnString.Text = connectionStr;
		}

		private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
		{
			var obj = cmbProvider.SelectedItem;
			SelectedProviderRow = ((DataRowView)obj).Row;
		}

		private void btnConfigureConnStr_Click(object sender, EventArgs e)
		{
			ClearErr();
			// configure right connection string          

			string connectionStr = string.Empty;

			if (rbSQLServerConnection.Checked)
				connectionStr = String.Format(rbSQLServerAuth.Checked ? SQLSERVER_SQLAUTH_CONNECTION_STRING : SQLSERVER_WINDOWSAUTH_CONNECTION_STRING
											, txtServer.Text.Trim()
											, txtDataBase.Text.Trim()
											, txtLogin.Text.Trim()
											, txtPassword.Text);
			else if (rbOLEDB.Checked)
				connectionStr = String.Format(OLEDB_EXCEL20xx_CONNECTION_STRING
											, txtDataBase.Text.Trim());
			else if (rbODBC.Checked)
				connectionStr = String.Format(ODBC_CONNECTION_STRING
											, txtServer.Text.Trim()
											, txtDataBase.Text.Trim()
											, txtLogin.Text.Trim()
											, txtPassword.Text);

			else if (rbDBFactory.Checked)
				CreateDBFactoryConnection(connectionStr);

			//string connectionStr = txtConnString.Text.Trim();
			txtConnString.Text = connectionStr;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			ClearErr();

			IsConnected = false;

			string connectionStr = txtConnString.Text.Trim();

			if (rbSQLServerConnection.Checked)
				DBConnection = CreateSQLConnection(connectionStr);
			else if (rbODBC.Checked)
				DBConnection = CreateODBCConnection(connectionStr);
			else if (rbOLEDB.Checked)
				DBConnection = CreateOleDbConnection(connectionStr);
			else if (rbDBFactory.Checked)
				DBConnection = CreateDBFactoryConnection(connectionStr);

			if (!IsConnected)
			{
				MessageBox.Show("Your DB connection failed !", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show(string.Format("DB connection to {0} success!", DBConnection.Database), "Connection success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			MessageBox.Show("DB Connection is not established !", "ERROR");
		}

		private void rbDBFactory_CheckedChanged(object sender, EventArgs e)
		{
			cmbProvider.Enabled = rbDBFactory.Checked;
		}

		private void rbAuth_CheckedChanged(object sender, EventArgs e)
		{
			grpLogin.Visible = rbSQLServerAuth.Checked;
			txtConnString.Text = rbSQLServerAuth.Checked ? SQLSERVER_SQLAUTH_CONNECTION_STRING : SQLSERVER_WINDOWSAUTH_CONNECTION_STRING;
		}

		private void ShowError(string msg)
		{
			txtError.Visible = true;
			txtError.Text = msg;
		}

		private void ClearErr()
		{
			txtError.Text = string.Empty;
			txtError.Text = string.Empty;
		}

		private void btnChooseDB_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Methods

		private DbConnection CreateSQLConnection(string connectionStr)
		{
			SqlConnection sqlConn = null;
			//using (var sqlConn = new SqlConnection())
			//{
			try
			{
				sqlConn = new SqlConnection();
				sqlConn.ConnectionString = connectionStr;
				sqlConn.Open();
				IsConnected = true;
				return sqlConn;
			}
			catch (SqlException ex)
			{
				if (sqlConn != null && sqlConn.State != ConnectionState.Closed)
					sqlConn.Close();
				ShowError("Sql Connection FAILED:" + ex.Message);
			}
			//finally
			//{
			//	if (sqlConn != null && sqlConn.State == ConnectionState.Open)
			//		sqlConn.Close();
			//}
			//}
			return null;
		}

		private DbConnection CreateODBCConnection(string connectionStr)
		{
			using (var odbcConn = new OdbcConnection())
			{
				try
				{
					//1. Try to open connection
					odbcConn.ConnectionString = connectionStr;
					//odbcConn.Driver= "SYC Sybase System 10/11"; odbcConn.DataSource="WFE_DEV"; odbcConn.Database="IFSTRS"; Uid=TRSWFE;Pwd=8vcumZydHC;
					odbcConn.Open();
					IsConnected = true;

					//2. Populate Data
					//FillDataTable(conn);                   
					IsConnected = true;
					return odbcConn;
				}
				catch (OdbcException ex)
				{
					ShowError("ODBC connection FAILED:" + ex.Message);
				}
				//finally
				//{
				//	if (odbcConn != null && odbcConn.State == ConnectionState.Open)
				//		odbcConn.Close();
				//}
			}
			return null;
		}

		private DbConnection CreateOleDbConnection(string connectionStr)
		{
			using (var oleDbConn = new OleDbConnection())
			{
				try
				{
					//1. Try to open Connection
					oleDbConn.ConnectionString = connectionStr;
					//odbcConn.Driver= "SYC Sybase System 10/11"; odbcConn.DataSource="WFE_DEV"; odbcConn.Database="IFSTRS"; Uid=TRSWFE;Pwd=8vcumZydHC;
					oleDbConn.Open();
					//2. Populate Data
					//FillDataTable(odbcConn);                   
					IsConnected = true;
					return oleDbConn;
				}
				catch (OleDbException ex)
				{
					ShowError("OleDb connection FAILED: " + ex.Message);
				}
				//finally
				//{
				//	if (oleDbConn != null && oleDbConn.State == ConnectionState.Open)
				//		oleDbConn.Close();
				//}
			}
			return null;
		}

		private DbConnection CreateDBFactoryConnection(string rightConnStr)
		{
			IsConnected = false;
			//ProviderInvariantName = cmbProvider.Text;//cmbProvider.SelectedItem.ToString();
			var dbConnection = TryToCreateConnectionType(SelectedProviderRow, rightConnStr);
			if (dbConnection != null)
			{
				IsConnected = true;
				return dbConnection;
			}
			return null;
		}

		private DbConnection TryToCreateConnectionType(DataRow ProviderRow, string rightConnStr)
		{
			try
			{
				DbProviderFactory dbFactory = DbProviderFactories.GetFactory(ProviderRow);
				//AseClientManagedProvider = Sybase.Data.AseClient      

				//2.Is ConnectionString right ?
				DbConnection conn = dbFactory.CreateConnection();
				if (conn != null)
				{
					conn.ConnectionString = rightConnStr;

					//3.Try to open connection
					conn.Open();
					IsConnected = true; //5. If all TrsDBConnection is Open =>IsConnected=true

					//4. Fill Funds DataTable
					//FillFundsDataTable(dbFactory, conn);
					System.Security.Principal.IIdentity currentUser = Thread.CurrentPrincipal.Identity;
					bool isAuth = currentUser.IsAuthenticated;
					return conn;
				}
			}
			catch (DbException ex)
			{
				ShowError("DbException__ :" + ex.Message + " .... " + ex.Source);
			}
			return null;
		}

		#endregion
	}
}