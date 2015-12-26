namespace DataImportUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnPanel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblServer = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtDataBase = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtConnString = new System.Windows.Forms.TextBox();
			this.btnFillConnStr = new System.Windows.Forms.Button();
			this.cmbProvider = new System.Windows.Forms.ComboBox();
			this.grpresultConnStr = new System.Windows.Forms.GroupBox();
			this.txtError = new System.Windows.Forms.RichTextBox();
			this.grpConnType = new System.Windows.Forms.GroupBox();
			this.rbSQLServerConnection = new System.Windows.Forms.RadioButton();
			this.rbOLEDB = new System.Windows.Forms.RadioButton();
			this.rbODBC = new System.Windows.Forms.RadioButton();
			this.rbDBFactory = new System.Windows.Forms.RadioButton();
			this.btnChooseDB = new System.Windows.Forms.Button();
			this.grpConnectionParameters = new System.Windows.Forms.GroupBox();
			this.grpLogin = new System.Windows.Forms.GroupBox();
			this.grpAuthType = new System.Windows.Forms.GroupBox();
			this.rbSQLServerAuth = new System.Windows.Forms.RadioButton();
			this.rbWindowsAuth = new System.Windows.Forms.RadioButton();
			this.btnPanel.SuspendLayout();
			this.grpresultConnStr.SuspendLayout();
			this.grpConnType.SuspendLayout();
			this.grpConnectionParameters.SuspendLayout();
			this.grpLogin.SuspendLayout();
			this.grpAuthType.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnLogin.Location = new System.Drawing.Point(138, 8);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(98, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "CONNECT";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnPanel
			// 
			this.btnPanel.BackColor = System.Drawing.Color.LightGray;
			this.btnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnPanel.Controls.Add(this.btnCancel);
			this.btnPanel.Controls.Add(this.btnLogin);
			this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnPanel.Location = new System.Drawing.Point(0, 346);
			this.btnPanel.Name = "btnPanel";
			this.btnPanel.Size = new System.Drawing.Size(529, 44);
			this.btnPanel.TabIndex = 13;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(251, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "DataBase";
			// 
			// txtServer
			// 
			this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServer.Location = new System.Drawing.Point(81, 26);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(241, 20);
			this.txtServer.TabIndex = 0;
			this.txtServer.Text = "rws-sql-beta1";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(6, 16);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(33, 13);
			this.lblLogin.TabIndex = 10;
			this.lblLogin.Text = "Login";
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Location = new System.Drawing.Point(9, 29);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(44, 13);
			this.lblServer.TabIndex = 7;
			this.lblServer.Text = "Server";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(66, 13);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(94, 20);
			this.txtLogin.TabIndex = 4;
			this.txtLogin.Text = "STORMAdmin";
			// 
			// txtDataBase
			// 
			this.txtDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataBase.Location = new System.Drawing.Point(81, 55);
			this.txtDataBase.Name = "txtDataBase";
			this.txtDataBase.Size = new System.Drawing.Size(241, 20);
			this.txtDataBase.TabIndex = 3;
			this.txtDataBase.Text = "STORM";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(6, 40);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 11;
			this.lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(68, 37);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(92, 20);
			this.txtPassword.TabIndex = 5;
			this.txtPassword.Text = "change";
			// 
			// txtConnString
			// 
			this.txtConnString.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtConnString.Location = new System.Drawing.Point(3, 16);
			this.txtConnString.Multiline = true;
			this.txtConnString.Name = "txtConnString";
			this.txtConnString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConnString.Size = new System.Drawing.Size(523, 60);
			this.txtConnString.TabIndex = 6;
			this.txtConnString.Text = "Data Source=\'{0}\';Initial Catalog=\'{1}\';Persist Security Info=True;User ID=\'{2}\';" +
    " Password=\'{3}\';";
			// 
			// btnFillConnStr
			// 
			this.btnFillConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFillConnStr.ForeColor = System.Drawing.Color.Blue;
			this.btnFillConnStr.Location = new System.Drawing.Point(139, 193);
			this.btnFillConnStr.Name = "btnFillConnStr";
			this.btnFillConnStr.Size = new System.Drawing.Size(98, 21);
			this.btnFillConnStr.TabIndex = 5;
			this.btnFillConnStr.Text = "CONFIGURE";
			this.btnFillConnStr.UseVisualStyleBackColor = true;
			this.btnFillConnStr.Click += new System.EventHandler(this.btnConfigureConnStr_Click);
			// 
			// cmbProvider
			// 
			this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProvider.FormattingEnabled = true;
			this.cmbProvider.Location = new System.Drawing.Point(136, 91);
			this.cmbProvider.Name = "cmbProvider";
			this.cmbProvider.Size = new System.Drawing.Size(169, 21);
			this.cmbProvider.TabIndex = 4;
			this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
			// 
			// grpresultConnStr
			// 
			this.grpresultConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpresultConnStr.Controls.Add(this.txtError);
			this.grpresultConnStr.Controls.Add(this.txtConnString);
			this.grpresultConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpresultConnStr.Location = new System.Drawing.Point(0, 220);
			this.grpresultConnStr.Name = "grpresultConnStr";
			this.grpresultConnStr.Size = new System.Drawing.Size(529, 120);
			this.grpresultConnStr.TabIndex = 7;
			this.grpresultConnStr.TabStop = false;
			this.grpresultConnStr.Text = "DB Connection String";
			// 
			// txtError
			// 
			this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtError.ForeColor = System.Drawing.Color.Red;
			this.txtError.Location = new System.Drawing.Point(3, 76);
			this.txtError.Name = "txtError";
			this.txtError.ReadOnly = true;
			this.txtError.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.txtError.Size = new System.Drawing.Size(523, 41);
			this.txtError.TabIndex = 20;
			this.txtError.Text = "";
			// 
			// grpConnType
			// 
			this.grpConnType.Controls.Add(this.rbSQLServerConnection);
			this.grpConnType.Controls.Add(this.rbOLEDB);
			this.grpConnType.Controls.Add(this.rbODBC);
			this.grpConnType.Controls.Add(this.cmbProvider);
			this.grpConnType.Controls.Add(this.rbDBFactory);
			this.grpConnType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpConnType.Location = new System.Drawing.Point(3, 12);
			this.grpConnType.Name = "grpConnType";
			this.grpConnType.Size = new System.Drawing.Size(130, 86);
			this.grpConnType.TabIndex = 6;
			this.grpConnType.TabStop = false;
			this.grpConnType.Text = "Connection Type";
			// 
			// rbSQLServerConnection
			// 
			this.rbSQLServerConnection.AutoSize = true;
			this.rbSQLServerConnection.Checked = true;
			this.rbSQLServerConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSQLServerConnection.Location = new System.Drawing.Point(23, 19);
			this.rbSQLServerConnection.Name = "rbSQLServerConnection";
			this.rbSQLServerConnection.Size = new System.Drawing.Size(80, 17);
			this.rbSQLServerConnection.TabIndex = 0;
			this.rbSQLServerConnection.TabStop = true;
			this.rbSQLServerConnection.Text = "SQL Server";
			this.rbSQLServerConnection.UseVisualStyleBackColor = true;
			this.rbSQLServerConnection.CheckedChanged += new System.EventHandler(this.rbConnectionType_CheckedChanged);
			// 
			// rbOLEDB
			// 
			this.rbOLEDB.AutoSize = true;
			this.rbOLEDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOLEDB.Location = new System.Drawing.Point(23, 42);
			this.rbOLEDB.Name = "rbOLEDB";
			this.rbOLEDB.Size = new System.Drawing.Size(64, 17);
			this.rbOLEDB.TabIndex = 1;
			this.rbOLEDB.TabStop = true;
			this.rbOLEDB.Text = "OLE DB";
			this.rbOLEDB.UseVisualStyleBackColor = true;
			this.rbOLEDB.CheckedChanged += new System.EventHandler(this.rbConnectionType_CheckedChanged);
			// 
			// rbODBC
			// 
			this.rbODBC.AutoSize = true;
			this.rbODBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbODBC.Location = new System.Drawing.Point(23, 65);
			this.rbODBC.Name = "rbODBC";
			this.rbODBC.Size = new System.Drawing.Size(55, 17);
			this.rbODBC.TabIndex = 2;
			this.rbODBC.TabStop = true;
			this.rbODBC.Text = "ODBC";
			this.rbODBC.UseVisualStyleBackColor = true;
			this.rbODBC.CheckedChanged += new System.EventHandler(this.rbConnectionType_CheckedChanged);
			// 
			// rbDBFactory
			// 
			this.rbDBFactory.AutoSize = true;
			this.rbDBFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDBFactory.Location = new System.Drawing.Point(9, 92);
			this.rbDBFactory.Name = "rbDBFactory";
			this.rbDBFactory.Size = new System.Drawing.Size(121, 17);
			this.rbDBFactory.TabIndex = 3;
			this.rbDBFactory.Text = "DBFactory providers";
			this.rbDBFactory.UseVisualStyleBackColor = true;
			this.rbDBFactory.CheckedChanged += new System.EventHandler(this.rbDBFactory_CheckedChanged);
			// 
			// btnChooseDB
			// 
			this.btnChooseDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChooseDB.Location = new System.Drawing.Point(328, 52);
			this.btnChooseDB.Name = "btnChooseDB";
			this.btnChooseDB.Size = new System.Drawing.Size(25, 23);
			this.btnChooseDB.TabIndex = 17;
			this.btnChooseDB.Text = "...";
			this.btnChooseDB.UseVisualStyleBackColor = true;
			this.btnChooseDB.Visible = false;
			this.btnChooseDB.Click += new System.EventHandler(this.btnChooseDB_Click);
			// 
			// grpConnectionParameters
			// 
			this.grpConnectionParameters.Controls.Add(this.grpLogin);
			this.grpConnectionParameters.Controls.Add(this.grpAuthType);
			this.grpConnectionParameters.Controls.Add(this.lblServer);
			this.grpConnectionParameters.Controls.Add(this.btnChooseDB);
			this.grpConnectionParameters.Controls.Add(this.txtDataBase);
			this.grpConnectionParameters.Controls.Add(this.txtServer);
			this.grpConnectionParameters.Controls.Add(this.label6);
			this.grpConnectionParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpConnectionParameters.Location = new System.Drawing.Point(139, 12);
			this.grpConnectionParameters.Name = "grpConnectionParameters";
			this.grpConnectionParameters.Size = new System.Drawing.Size(363, 165);
			this.grpConnectionParameters.TabIndex = 18;
			this.grpConnectionParameters.TabStop = false;
			this.grpConnectionParameters.Text = "Connection data";
			// 
			// grpLogin
			// 
			this.grpLogin.Controls.Add(this.lblLogin);
			this.grpLogin.Controls.Add(this.lblPassword);
			this.grpLogin.Controls.Add(this.txtPassword);
			this.grpLogin.Controls.Add(this.txtLogin);
			this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpLogin.Location = new System.Drawing.Point(136, 86);
			this.grpLogin.Name = "grpLogin";
			this.grpLogin.Size = new System.Drawing.Size(186, 68);
			this.grpLogin.TabIndex = 19;
			this.grpLogin.TabStop = false;
			// 
			// grpAuthType
			// 
			this.grpAuthType.Controls.Add(this.rbSQLServerAuth);
			this.grpAuthType.Controls.Add(this.rbWindowsAuth);
			this.grpAuthType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpAuthType.Location = new System.Drawing.Point(12, 89);
			this.grpAuthType.Name = "grpAuthType";
			this.grpAuthType.Size = new System.Drawing.Size(115, 65);
			this.grpAuthType.TabIndex = 19;
			this.grpAuthType.TabStop = false;
			this.grpAuthType.Text = "Authentication";
			// 
			// rbSQLServerAuth
			// 
			this.rbSQLServerAuth.AutoSize = true;
			this.rbSQLServerAuth.Checked = true;
			this.rbSQLServerAuth.Location = new System.Drawing.Point(14, 36);
			this.rbSQLServerAuth.Name = "rbSQLServerAuth";
			this.rbSQLServerAuth.Size = new System.Drawing.Size(80, 17);
			this.rbSQLServerAuth.TabIndex = 19;
			this.rbSQLServerAuth.TabStop = true;
			this.rbSQLServerAuth.Text = "SQL Server";
			this.rbSQLServerAuth.UseVisualStyleBackColor = true;
			this.rbSQLServerAuth.CheckedChanged += new System.EventHandler(this.rbAuth_CheckedChanged);
			// 
			// rbWindowsAuth
			// 
			this.rbWindowsAuth.AutoSize = true;
			this.rbWindowsAuth.Location = new System.Drawing.Point(14, 19);
			this.rbWindowsAuth.Name = "rbWindowsAuth";
			this.rbWindowsAuth.Size = new System.Drawing.Size(69, 17);
			this.rbWindowsAuth.TabIndex = 18;
			this.rbWindowsAuth.Text = "Windows";
			this.rbWindowsAuth.UseVisualStyleBackColor = true;
			this.rbWindowsAuth.CheckedChanged += new System.EventHandler(this.rbAuth_CheckedChanged);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 390);
			this.Controls.Add(this.grpConnectionParameters);
			this.Controls.Add(this.btnFillConnStr);
			this.Controls.Add(this.grpConnType);
			this.Controls.Add(this.grpresultConnStr);
			this.Controls.Add(this.btnPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Please, set up connection parameters to TARGET database";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.btnPanel.ResumeLayout(false);
			this.grpresultConnStr.ResumeLayout(false);
			this.grpresultConnStr.PerformLayout();
			this.grpConnType.ResumeLayout(false);
			this.grpConnType.PerformLayout();
			this.grpConnectionParameters.ResumeLayout(false);
			this.grpConnectionParameters.PerformLayout();
			this.grpLogin.ResumeLayout(false);
			this.grpLogin.PerformLayout();
			this.grpAuthType.ResumeLayout(false);
			this.grpAuthType.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label lblPassword;
				private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Button btnFillConnStr;
        private System.Windows.Forms.ComboBox cmbProvider;
				private System.Windows.Forms.GroupBox grpresultConnStr;
        private System.Windows.Forms.GroupBox grpConnType;
        private System.Windows.Forms.RadioButton rbOLEDB;
        private System.Windows.Forms.RadioButton rbODBC;
        private System.Windows.Forms.RadioButton rbDBFactory;
        private System.Windows.Forms.Button btnChooseDB;
				private System.Windows.Forms.RadioButton rbSQLServerConnection;
				private System.Windows.Forms.GroupBox grpConnectionParameters;
				private System.Windows.Forms.RichTextBox txtError;
				private System.Windows.Forms.GroupBox grpLogin;
				private System.Windows.Forms.GroupBox grpAuthType;
				private System.Windows.Forms.RadioButton rbSQLServerAuth;
				private System.Windows.Forms.RadioButton rbWindowsAuth;
    }
}