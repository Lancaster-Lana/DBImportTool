using DataImportTool.Tools;

namespace DataImportUI
{
	partial class DBImportToolWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSourceDBFile = new System.Windows.Forms.TextBox();
			this.txtSQLServerConnStr = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOpenExcelFile = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSourceTablePK = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabCtrlSourceDB = new System.Windows.Forms.TabControl();
			this.tabDBData = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtTargetTablePK = new System.Windows.Forms.TextBox();
			this.gridTargetTable = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbTargetTable = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbSourceTable = new System.Windows.Forms.ComboBox();
			this.gridSourceTable = new System.Windows.Forms.DataGridView();
			this.tabDBImport = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnConnectSQLSerer = new System.Windows.Forms.Button();
			this.ucImportMapping = new DataImportTool.Tools.DBImportSettings();
			this.groupBox1.SuspendLayout();
			this.tabCtrlSourceDB.SuspendLayout();
			this.tabDBData.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTargetTable)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSourceTable)).BeginInit();
			this.tabDBImport.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(20, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please, select a source file";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(15, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "SQL Server connection string";
			// 
			// txtSourceDBFile
			// 
			this.txtSourceDBFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSourceDBFile.Location = new System.Drawing.Point(19, 51);
			this.txtSourceDBFile.Name = "txtSourceDBFile";
			this.txtSourceDBFile.Size = new System.Drawing.Size(601, 20);
			this.txtSourceDBFile.TabIndex = 2;
			this.txtSourceDBFile.Text = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0" +
    " Xml;HDR=YES\";";
			// 
			// txtSQLServerConnStr
			// 
			this.txtSQLServerConnStr.Enabled = false;
			this.txtSQLServerConnStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSQLServerConnStr.Location = new System.Drawing.Point(18, 51);
			this.txtSQLServerConnStr.Name = "txtSQLServerConnStr";
			this.txtSQLServerConnStr.Size = new System.Drawing.Size(630, 20);
			this.txtSQLServerConnStr.TabIndex = 0;
			this.txtSQLServerConnStr.Text = "Data Source=rws-sql-beta1;  Initial Catalog=STORM;  User ID=STORMAdmin;Password=";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(27, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Table";
			// 
			// btnOpenExcelFile
			// 
			this.btnOpenExcelFile.Location = new System.Drawing.Point(626, 48);
			this.btnOpenExcelFile.Name = "btnOpenExcelFile";
			this.btnOpenExcelFile.Size = new System.Drawing.Size(35, 23);
			this.btnOpenExcelFile.TabIndex = 7;
			this.btnOpenExcelFile.Text = "...";
			this.btnOpenExcelFile.UseVisualStyleBackColor = true;
			this.btnOpenExcelFile.Click += new System.EventHandler(this.btnOpenSourceDBFile_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnOpenExcelFile);
			this.groupBox1.Controls.Add(this.txtSourceDBFile);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(4, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(667, 93);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SOURCE OleDb database (from=*.xlsx, *.mdb)";
			// 
			// txtSourceTablePK
			// 
			this.txtSourceTablePK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSourceTablePK.Location = new System.Drawing.Point(419, 33);
			this.txtSourceTablePK.Name = "txtSourceTablePK";
			this.txtSourceTablePK.ReadOnly = true;
			this.txtSourceTablePK.Size = new System.Drawing.Size(211, 20);
			this.txtSourceTablePK.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(371, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "PK";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Table";
			// 
			// tabCtrlSourceDB
			// 
			this.tabCtrlSourceDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlSourceDB.Controls.Add(this.tabDBData);
			this.tabCtrlSourceDB.Controls.Add(this.tabDBImport);
			this.tabCtrlSourceDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabCtrlSourceDB.Location = new System.Drawing.Point(4, 111);
			this.tabCtrlSourceDB.Name = "tabCtrlSourceDB";
			this.tabCtrlSourceDB.SelectedIndex = 0;
			this.tabCtrlSourceDB.Size = new System.Drawing.Size(1359, 631);
			this.tabCtrlSourceDB.TabIndex = 14;
			// 
			// tabDBData
			// 
			this.tabDBData.Controls.Add(this.groupBox4);
			this.tabDBData.Controls.Add(this.groupBox3);
			this.tabDBData.Location = new System.Drawing.Point(4, 22);
			this.tabDBData.Name = "tabDBData";
			this.tabDBData.Padding = new System.Windows.Forms.Padding(3);
			this.tabDBData.Size = new System.Drawing.Size(1351, 605);
			this.tabDBData.TabIndex = 0;
			this.tabDBData.Text = "DB DATA";
			this.tabDBData.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.txtTargetTablePK);
			this.groupBox4.Controls.Add(this.gridTargetTable);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.cmbTargetTable);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.ForeColor = System.Drawing.Color.DarkViolet;
			this.groupBox4.Location = new System.Drawing.Point(673, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(784, 614);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "TARGET Table Data";
			// 
			// txtTargetTablePK
			// 
			this.txtTargetTablePK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTargetTablePK.Location = new System.Drawing.Point(435, 30);
			this.txtTargetTablePK.Name = "txtTargetTablePK";
			this.txtTargetTablePK.ReadOnly = true;
			this.txtTargetTablePK.Size = new System.Drawing.Size(242, 20);
			this.txtTargetTablePK.TabIndex = 20;
			// 
			// gridTargetTable
			// 
			this.gridTargetTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridTargetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTargetTable.Location = new System.Drawing.Point(3, 91);
			this.gridTargetTable.Name = "gridTargetTable";
			this.gridTargetTable.Size = new System.Drawing.Size(668, 506);
			this.gridTargetTable.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(372, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "PK";
			// 
			// cmbTargetTable
			// 
			this.cmbTargetTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTargetTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTargetTable.Location = new System.Drawing.Point(67, 30);
			this.cmbTargetTable.Name = "cmbTargetTable";
			this.cmbTargetTable.Size = new System.Drawing.Size(242, 21);
			this.cmbTargetTable.TabIndex = 15;
			this.cmbTargetTable.SelectedIndexChanged += new System.EventHandler(this.cmbTargetTable_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbSourceTable);
			this.groupBox3.Controls.Add(this.txtSourceTablePK);
			this.groupBox3.Controls.Add(this.gridSourceTable);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.ForeColor = System.Drawing.Color.ForestGreen;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(656, 599);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "SOURCE Table Data";
			// 
			// cmbSourceTable
			// 
			this.cmbSourceTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSourceTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSourceTable.Location = new System.Drawing.Point(62, 33);
			this.cmbSourceTable.Name = "cmbSourceTable";
			this.cmbSourceTable.Size = new System.Drawing.Size(242, 21);
			this.cmbSourceTable.TabIndex = 16;
			this.cmbSourceTable.SelectedIndexChanged += new System.EventHandler(this.cmbSourceTable_SelectedIndexChanged);
			// 
			// gridSourceTable
			// 
			this.gridSourceTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridSourceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridSourceTable.Location = new System.Drawing.Point(3, 94);
			this.gridSourceTable.Name = "gridSourceTable";
			this.gridSourceTable.Size = new System.Drawing.Size(650, 503);
			this.gridSourceTable.TabIndex = 13;
			// 
			// tabDBImport
			// 
			this.tabDBImport.Controls.Add(this.ucImportMapping);
			this.tabDBImport.Location = new System.Drawing.Point(4, 22);
			this.tabDBImport.Name = "tabDBImport";
			this.tabDBImport.Padding = new System.Windows.Forms.Padding(3);
			this.tabDBImport.Size = new System.Drawing.Size(1351, 605);
			this.tabDBImport.TabIndex = 1;
			this.tabDBImport.Text = "DB Import";
			this.tabDBImport.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnConnectSQLSerer);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtSQLServerConnStr);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(681, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(697, 93);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "TARGET database (*.mdf)";
			// 
			// btnConnectSQLSerer
			// 
			this.btnConnectSQLSerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnConnectSQLSerer.Location = new System.Drawing.Point(654, 47);
			this.btnConnectSQLSerer.Name = "btnConnectSQLSerer";
			this.btnConnectSQLSerer.Size = new System.Drawing.Size(37, 24);
			this.btnConnectSQLSerer.TabIndex = 1;
			this.btnConnectSQLSerer.Tag = " ";
			this.btnConnectSQLSerer.Text = "...";
			this.btnConnectSQLSerer.UseVisualStyleBackColor = true;
			this.btnConnectSQLSerer.Click += new System.EventHandler(this.btnConnectSQLSerer_Click);
			// 
			// ucImportMapping
			// 
			this.ucImportMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucImportMapping.Location = new System.Drawing.Point(3, 3);
			this.ucImportMapping.Name = "ucImportMapping";
			this.ucImportMapping.Size = new System.Drawing.Size(1345, 599);
			this.ucImportMapping.SourceDbConnection = null;
			this.ucImportMapping.TabIndex = 4;
			this.ucImportMapping.TargetDbConnection = null;
			// 
			// DBImportToolWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1362, 742);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tabCtrlSourceDB);
			this.Name = "DBImportToolWindow";
			this.Text = "DB Import tool";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabCtrlSourceDB.ResumeLayout(false);
			this.tabDBData.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTargetTable)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSourceTable)).EndInit();
			this.tabDBImport.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSourceDBFile;
		private System.Windows.Forms.TextBox txtSQLServerConnStr;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOpenExcelFile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView gridSourceTable;
		private System.Windows.Forms.TabControl tabCtrlSourceDB;
		private System.Windows.Forms.TabPage tabDBData;
		private System.Windows.Forms.Button btnConnectSQLSerer;
		private System.Windows.Forms.DataGridView gridTargetTable;
		private System.Windows.Forms.ComboBox cmbTargetTable;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSourceTablePK;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTargetTablePK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabDBImport;
		private DataImportTool.Tools.DBImportSettings ucImportMapping;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cmbSourceTable;
	}
}

