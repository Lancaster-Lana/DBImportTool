namespace DataImportTool.Tools
{
	partial class DBImportSettings
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBImportSettings));
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbTargetTable = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.grImportedColumns = new System.Windows.Forms.GroupBox();
			this.gridColumnsMapping = new System.Windows.Forms.DataGridView();
			this.sourceGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colFunction = new System.Windows.Forms.DataGridViewButtonColumn();
			this.targetDataGridViewColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.isPKJoinDataGridViewColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.targetTypeDataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsMappingColumns = new System.Windows.Forms.BindingSource(this.components);
			this.dsMappingColumns = new System.Data.DataSet();
			this.tbMappingColumns = new System.Data.DataTable();
			this.colSourceColumn = new System.Data.DataColumn();
			this.colTargetColumn = new System.Data.DataColumn();
			this.colIsKey = new System.Data.DataColumn();
			this.colTargetType = new System.Data.DataColumn();
			this.navMappingColumns = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDirectImport = new System.Windows.Forms.Button();
			this.btnGenerateImportScript = new System.Windows.Forms.Button();
			this.txtTargetScript = new System.Windows.Forms.TextBox();
			this.cntxMenuSQLUpdateScript = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miSaveSQLUpdateScript = new System.Windows.Forms.ToolStripMenuItem();
			this.cmbSourceTable = new System.Windows.Forms.ComboBox();
			this.btnApplyUpdateScript = new System.Windows.Forms.Button();
			this.tabCtrlScripts = new System.Windows.Forms.TabControl();
			this.tabScriptResult = new System.Windows.Forms.TabPage();
			this.txtResultUpdateScript = new System.Windows.Forms.TextBox();
			this.tabSQLScriptForDirectUpdate = new System.Windows.Forms.TabPage();
			this.tabCursorScript = new System.Windows.Forms.TabPage();
			this.btnPrepareImportScript = new System.Windows.Forms.Button();
			this.txtSQLCursorScript = new System.Windows.Forms.TextBox();
			this.tabImportWithRowset = new System.Windows.Forms.TabPage();
			this.txtRowsetDynamicUpdateSQLScript = new System.Windows.Forms.TextBox();
			this.btnRunScriptOnTarget = new System.Windows.Forms.Button();
			this.cmbSourceTablePK = new System.Windows.Forms.ComboBox();
			this.cmbTargetTablePK = new System.Windows.Forms.ComboBox();
			this.grImportedColumns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridColumnsMapping)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMappingColumns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMappingColumns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbMappingColumns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navMappingColumns)).BeginInit();
			this.navMappingColumns.SuspendLayout();
			this.cntxMenuSQLUpdateScript.SuspendLayout();
			this.tabCtrlScripts.SuspendLayout();
			this.tabScriptResult.SuspendLayout();
			this.tabSQLScriptForDirectUpdate.SuspendLayout();
			this.tabCursorScript.SuspendLayout();
			this.tabImportWithRowset.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.ForestGreen;
			this.label5.Location = new System.Drawing.Point(33, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = " PK";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.ForestGreen;
			this.label4.Location = new System.Drawing.Point(11, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "SOURCE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.DarkViolet;
			this.label6.Location = new System.Drawing.Point(338, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = " PK";
			// 
			// cmbTargetTable
			// 
			this.cmbTargetTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTargetTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTargetTable.ForeColor = System.Drawing.Color.DarkViolet;
			this.cmbTargetTable.Location = new System.Drawing.Point(372, 9);
			this.cmbTargetTable.Name = "cmbTargetTable";
			this.cmbTargetTable.Size = new System.Drawing.Size(214, 21);
			this.cmbTargetTable.TabIndex = 24;
			this.cmbTargetTable.SelectedIndexChanged += new System.EventHandler(this.cmbTargetTable_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(308, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 23;
			this.label3.Text = "TARGET";
			// 
			// grImportedColumns
			// 
			this.grImportedColumns.Controls.Add(this.gridColumnsMapping);
			this.grImportedColumns.Controls.Add(this.navMappingColumns);
			this.grImportedColumns.Location = new System.Drawing.Point(10, 69);
			this.grImportedColumns.Name = "grImportedColumns";
			this.grImportedColumns.Size = new System.Drawing.Size(1134, 182);
			this.grImportedColumns.TabIndex = 28;
			this.grImportedColumns.TabStop = false;
			this.grImportedColumns.Text = "COLUMNS MAPPING : SOURCE=>TARGET";
			// 
			// gridColumnsMapping
			// 
			this.gridColumnsMapping.AllowUserToAddRows = false;
			this.gridColumnsMapping.AllowUserToOrderColumns = true;
			this.gridColumnsMapping.AutoGenerateColumns = false;
			this.gridColumnsMapping.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridColumnsMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridColumnsMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceGridViewColumn,
            this.colFunction,
            this.targetDataGridViewColumn,
            this.isPKJoinDataGridViewColumn,
            this.targetTypeDataGridViewColumn});
			this.gridColumnsMapping.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gridColumnsMapping.DataSource = this.bsMappingColumns;
			this.gridColumnsMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridColumnsMapping.GridColor = System.Drawing.SystemColors.Control;
			this.gridColumnsMapping.Location = new System.Drawing.Point(3, 41);
			this.gridColumnsMapping.MultiSelect = false;
			this.gridColumnsMapping.Name = "gridColumnsMapping";
			this.gridColumnsMapping.RowTemplate.Height = 25;
			this.gridColumnsMapping.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.gridColumnsMapping.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.gridColumnsMapping.Size = new System.Drawing.Size(1106, 138);
			this.gridColumnsMapping.StandardTab = true;
			this.gridColumnsMapping.TabIndex = 34; 
			this.gridColumnsMapping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumnsMapping_CellContentClick);
			this.gridColumnsMapping.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColumnsMapping_CellEndEdit);
			this.gridColumnsMapping.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridColumnsMapping_CellValidating);
			this.gridColumnsMapping.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridColumnsMapping_DataError);
			this.gridColumnsMapping.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridColumnsMapping_EditingControlShowing);
			// 
			// sourceGridViewColumn
			// 
			this.sourceGridViewColumn.DataPropertyName = "colSourceColumn";
			this.sourceGridViewColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.sourceGridViewColumn.Frozen = true;
			this.sourceGridViewColumn.HeaderText = "Source Column";
			this.sourceGridViewColumn.Name = "sourceGridViewColumn";
			this.sourceGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.sourceGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.sourceGridViewColumn.Width = 400;
			// 
			// colFunction
			// 
			this.colFunction.Frozen = true;
			this.colFunction.HeaderText = "F";
			this.colFunction.Name = "colFunction";
			this.colFunction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colFunction.Text = "F";
			this.colFunction.ToolTipText = "Select function for calculated field";
			this.colFunction.UseColumnTextForButtonValue = true;
			this.colFunction.Width = 30;
			// 
			// targetDataGridViewColumn
			// 
			this.targetDataGridViewColumn.DataPropertyName = "colTargetColumn";
			this.targetDataGridViewColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.targetDataGridViewColumn.HeaderText = "Target Column";
			this.targetDataGridViewColumn.Name = "targetDataGridViewColumn";
			this.targetDataGridViewColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.targetDataGridViewColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.targetDataGridViewColumn.Width = 350;
			// 
			// isPKJoinDataGridViewColumn
			// 
			this.isPKJoinDataGridViewColumn.DataPropertyName = "colIsKey";
			this.isPKJoinDataGridViewColumn.HeaderText = "Use as KEY (inner join)";
			this.isPKJoinDataGridViewColumn.Name = "isPKJoinDataGridViewColumn";
			// 
			// targetTypeDataGridViewColumn
			// 
			this.targetTypeDataGridViewColumn.DataPropertyName = "colTargetType";
			this.targetTypeDataGridViewColumn.HeaderText = "Target Type";
			this.targetTypeDataGridViewColumn.Name = "targetTypeDataGridViewColumn";
			this.targetTypeDataGridViewColumn.Width = 200;
			// 
			// bsMappingColumns
			// 
			this.bsMappingColumns.DataMember = "tbMappingColumns";
			this.bsMappingColumns.DataSource = this.dsMappingColumns;
			// 
			// dsMappingColumns
			// 
			this.dsMappingColumns.DataSetName = "dsMappingColumns";
			this.dsMappingColumns.Tables.AddRange(new System.Data.DataTable[] {
            this.tbMappingColumns});
			// 
			// tbMappingColumns
			// 
			this.tbMappingColumns.Columns.AddRange(new System.Data.DataColumn[] {
            this.colSourceColumn,
            this.colTargetColumn,
            this.colIsKey,
            this.colTargetType});
			this.tbMappingColumns.TableName = "tbMappingColumns";
			// 
			// colSourceColumn
			// 
			this.colSourceColumn.Caption = "Source Column";
			this.colSourceColumn.ColumnMapping = System.Data.MappingType.Attribute;
			this.colSourceColumn.ColumnName = "colSourceColumn";
			this.colSourceColumn.DataType = typeof(object);
			// 
			// colTargetColumn
			// 
			this.colTargetColumn.Caption = "Target Column";
			this.colTargetColumn.ColumnName = "colTargetColumn";
			// 
			// colIsKey
			// 
			this.colIsKey.ColumnName = "colIsKey";
			this.colIsKey.DataType = typeof(bool);
			// 
			// colTargetType
			// 
			this.colTargetType.ColumnName = "colTargetType";
			// 
			// navMappingColumns
			// 
			this.navMappingColumns.AddNewItem = this.bindingNavigatorAddNewItem;
			this.navMappingColumns.BindingSource = this.bsMappingColumns;
			this.navMappingColumns.CountItem = this.bindingNavigatorCountItem;
			this.navMappingColumns.DeleteItem = this.bindingNavigatorDeleteItem;
			this.navMappingColumns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.navMappingColumns.Location = new System.Drawing.Point(3, 16);
			this.navMappingColumns.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.navMappingColumns.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.navMappingColumns.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.navMappingColumns.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.navMappingColumns.Name = "navMappingColumns";
			this.navMappingColumns.PositionItem = this.bindingNavigatorPositionItem;
			this.navMappingColumns.Size = new System.Drawing.Size(1128, 25);
			this.navMappingColumns.TabIndex = 33;
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnDirectImport
			// 
			this.btnDirectImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDirectImport.Location = new System.Drawing.Point(7, 17);
			this.btnDirectImport.Name = "btnDirectImport";
			this.btnDirectImport.Size = new System.Drawing.Size(107, 23);
			this.btnDirectImport.TabIndex = 29;
			this.btnDirectImport.Text = "RUN direct import";
			this.btnDirectImport.UseVisualStyleBackColor = true;
			this.btnDirectImport.Click += new System.EventHandler(this.btnDirectImport_Click);
			// 
			// btnGenerateImportScript
			// 
			this.btnGenerateImportScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGenerateImportScript.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnGenerateImportScript.Location = new System.Drawing.Point(6, 6);
			this.btnGenerateImportScript.Name = "btnGenerateImportScript";
			this.btnGenerateImportScript.Size = new System.Drawing.Size(148, 23);
			this.btnGenerateImportScript.TabIndex = 30;
			this.btnGenerateImportScript.Text = "Generate DB Import Script";
			this.btnGenerateImportScript.UseVisualStyleBackColor = true;
			this.btnGenerateImportScript.Click += new System.EventHandler(this.btnGenerateImportScript_Click);
			// 
			// txtTargetScript
			// 
			this.txtTargetScript.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtTargetScript.ContextMenuStrip = this.cntxMenuSQLUpdateScript;
			this.txtTargetScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTargetScript.Location = new System.Drawing.Point(0, 35);
			this.txtTargetScript.Multiline = true;
			this.txtTargetScript.Name = "txtTargetScript";
			this.txtTargetScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTargetScript.Size = new System.Drawing.Size(1118, 170);
			this.txtTargetScript.TabIndex = 31;
			this.txtTargetScript.Text = "[Result SQL script to be applied onTarget DB]";
			// 
			// cntxMenuSQLUpdateScript
			// 
			this.cntxMenuSQLUpdateScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaveSQLUpdateScript});
			this.cntxMenuSQLUpdateScript.Name = "cntxMenuScript";
			this.cntxMenuSQLUpdateScript.Size = new System.Drawing.Size(164, 26);
			// 
			// miSaveSQLUpdateScript
			// 
			this.miSaveSQLUpdateScript.Image = global::DataImportTool.Properties.Resources.Save;
			this.miSaveSQLUpdateScript.Name = "miSaveSQLUpdateScript";
			this.miSaveSQLUpdateScript.Size = new System.Drawing.Size(163, 22);
			this.miSaveSQLUpdateScript.Text = "Save script to file";
			this.miSaveSQLUpdateScript.Click += new System.EventHandler(this.miSaveSQLUpdateScript_Click);
			// 
			// cmbSourceTable
			// 
			this.cmbSourceTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSourceTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSourceTable.ForeColor = System.Drawing.Color.ForestGreen;
			this.cmbSourceTable.Location = new System.Drawing.Point(76, 9);
			this.cmbSourceTable.Name = "cmbSourceTable";
			this.cmbSourceTable.Size = new System.Drawing.Size(208, 21);
			this.cmbSourceTable.TabIndex = 32;
			this.cmbSourceTable.SelectedIndexChanged += new System.EventHandler(this.cmbSourceTable_SelectedIndexChanged);
			// 
			// btnApplyUpdateScript
			// 
			this.btnApplyUpdateScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnApplyUpdateScript.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnApplyUpdateScript.Location = new System.Drawing.Point(3, 214);
			this.btnApplyUpdateScript.Name = "btnApplyUpdateScript";
			this.btnApplyUpdateScript.Size = new System.Drawing.Size(167, 23);
			this.btnApplyUpdateScript.TabIndex = 33;
			this.btnApplyUpdateScript.Text = "Apply Script on Target DB";
			this.btnApplyUpdateScript.UseVisualStyleBackColor = true;
			this.btnApplyUpdateScript.Click += new System.EventHandler(this.btnApplyUpdateScript_Click);
			// 
			// tabCtrlScripts
			// 
			this.tabCtrlScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlScripts.Controls.Add(this.tabScriptResult);
			this.tabCtrlScripts.Controls.Add(this.tabSQLScriptForDirectUpdate);
			this.tabCtrlScripts.Controls.Add(this.tabCursorScript);
			this.tabCtrlScripts.Controls.Add(this.tabImportWithRowset);
			this.tabCtrlScripts.Location = new System.Drawing.Point(0, 257);
			this.tabCtrlScripts.Name = "tabCtrlScripts";
			this.tabCtrlScripts.SelectedIndex = 0;
			this.tabCtrlScripts.Size = new System.Drawing.Size(1132, 368);
			this.tabCtrlScripts.TabIndex = 34;
			// 
			// tabScriptResult
			// 
			this.tabScriptResult.Controls.Add(this.txtResultUpdateScript);
			this.tabScriptResult.Controls.Add(this.txtTargetScript);
			this.tabScriptResult.Controls.Add(this.btnGenerateImportScript);
			this.tabScriptResult.Controls.Add(this.btnApplyUpdateScript);
			this.tabScriptResult.Location = new System.Drawing.Point(4, 22);
			this.tabScriptResult.Name = "tabScriptResult";
			this.tabScriptResult.Padding = new System.Windows.Forms.Padding(3);
			this.tabScriptResult.Size = new System.Drawing.Size(1124, 342);
			this.tabScriptResult.TabIndex = 2;
			this.tabScriptResult.Text = "Generate\\Apply SQL DB Import Script for TargetDB";
			this.tabScriptResult.UseVisualStyleBackColor = true;
			// 
			// txtResultUpdateScript
			// 
			this.txtResultUpdateScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtResultUpdateScript.ForeColor = System.Drawing.Color.Maroon;
			this.txtResultUpdateScript.Location = new System.Drawing.Point(169, 216);
			this.txtResultUpdateScript.Multiline = true;
			this.txtResultUpdateScript.Name = "txtResultUpdateScript";
			this.txtResultUpdateScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResultUpdateScript.Size = new System.Drawing.Size(949, 148);
			this.txtResultUpdateScript.TabIndex = 34;
			this.txtResultUpdateScript.Text = "RESULT UPDATE SCRIPT";
			// 
			// tabSQLScriptForDirectUpdate
			// 
			this.tabSQLScriptForDirectUpdate.Controls.Add(this.btnDirectImport);
			this.tabSQLScriptForDirectUpdate.Location = new System.Drawing.Point(4, 22);
			this.tabSQLScriptForDirectUpdate.Name = "tabSQLScriptForDirectUpdate";
			this.tabSQLScriptForDirectUpdate.Padding = new System.Windows.Forms.Padding(3);
			this.tabSQLScriptForDirectUpdate.Size = new System.Drawing.Size(1124, 342);
			this.tabSQLScriptForDirectUpdate.TabIndex = 1;
			this.tabSQLScriptForDirectUpdate.Text = "DIRECT (BulkCopy) update of Target DB";
			this.tabSQLScriptForDirectUpdate.UseVisualStyleBackColor = true;
			// 
			// tabCursorScript
			// 
			this.tabCursorScript.Controls.Add(this.btnPrepareImportScript);
			this.tabCursorScript.Controls.Add(this.txtSQLCursorScript);
			this.tabCursorScript.Location = new System.Drawing.Point(4, 22);
			this.tabCursorScript.Name = "tabCursorScript";
			this.tabCursorScript.Padding = new System.Windows.Forms.Padding(3);
			this.tabCursorScript.Size = new System.Drawing.Size(1124, 342);
			this.tabCursorScript.TabIndex = 0;
			this.tabCursorScript.Text = "SQL script generator with CURSOR ";
			this.tabCursorScript.Visible = false;
			// 
			// btnPrepareImportScript
			// 
			this.btnPrepareImportScript.Location = new System.Drawing.Point(6, 16);
			this.btnPrepareImportScript.Name = "btnPrepareImportScript";
			this.btnPrepareImportScript.Size = new System.Drawing.Size(250, 23);
			this.btnPrepareImportScript.TabIndex = 34;
			this.btnPrepareImportScript.Text = "Prepare script to generate target DB UPDATES";
			this.btnPrepareImportScript.UseVisualStyleBackColor = true;
			this.btnPrepareImportScript.Click += new System.EventHandler(this.btnPrepareImportScript_Click);
			// 
			// txtSQLCursorScript
			// 
			this.txtSQLCursorScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSQLCursorScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSQLCursorScript.Location = new System.Drawing.Point(6, 45);
			this.txtSQLCursorScript.Multiline = true;
			this.txtSQLCursorScript.Name = "txtSQLCursorScript";
			this.txtSQLCursorScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSQLCursorScript.Size = new System.Drawing.Size(1118, 294);
			this.txtSQLCursorScript.TabIndex = 6;
			this.txtSQLCursorScript.Text = resources.GetString("txtSQLCursorScript.Text");
			// 
			// tabImportWithRowset
			// 
			this.tabImportWithRowset.Controls.Add(this.txtRowsetDynamicUpdateSQLScript);
			this.tabImportWithRowset.Controls.Add(this.btnRunScriptOnTarget);
			this.tabImportWithRowset.Location = new System.Drawing.Point(4, 22);
			this.tabImportWithRowset.Name = "tabImportWithRowset";
			this.tabImportWithRowset.Padding = new System.Windows.Forms.Padding(3);
			this.tabImportWithRowset.Size = new System.Drawing.Size(1124, 342);
			this.tabImportWithRowset.TabIndex = 3;
			this.tabImportWithRowset.Text = "OPENROWSET for direct select SOURCE Data";
			this.tabImportWithRowset.UseVisualStyleBackColor = true;
			this.tabImportWithRowset.Enter += new System.EventHandler(this.tabImportWithRowset_Enter);
			// 
			// txtRowsetDynamicUpdateSQLScript
			// 
			this.txtRowsetDynamicUpdateSQLScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtRowsetDynamicUpdateSQLScript.Location = new System.Drawing.Point(6, 25);
			this.txtRowsetDynamicUpdateSQLScript.Multiline = true;
			this.txtRowsetDynamicUpdateSQLScript.Name = "txtRowsetDynamicUpdateSQLScript";
			this.txtRowsetDynamicUpdateSQLScript.Size = new System.Drawing.Size(1111, 112);
			this.txtRowsetDynamicUpdateSQLScript.TabIndex = 12;
			this.txtRowsetDynamicUpdateSQLScript.Text = resources.GetString("txtRowsetDynamicUpdateSQLScript.Text");
			// 
			// btnRunScriptOnTarget
			// 
			this.btnRunScriptOnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRunScriptOnTarget.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnRunScriptOnTarget.Location = new System.Drawing.Point(3, 143);
			this.btnRunScriptOnTarget.Name = "btnRunScriptOnTarget";
			this.btnRunScriptOnTarget.Size = new System.Drawing.Size(115, 23);
			this.btnRunScriptOnTarget.TabIndex = 11;
			this.btnRunScriptOnTarget.Text = "RUN script";
			this.btnRunScriptOnTarget.UseVisualStyleBackColor = true;
			this.btnRunScriptOnTarget.Click += new System.EventHandler(this.btnRunScriptOnTarget_Click);
			// 
			// cmbSourceTablePK
			// 
			this.cmbSourceTablePK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSourceTablePK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSourceTablePK.Enabled = false;
			this.cmbSourceTablePK.ForeColor = System.Drawing.Color.ForestGreen;
			this.cmbSourceTablePK.Location = new System.Drawing.Point(76, 36);
			this.cmbSourceTablePK.Name = "cmbSourceTablePK";
			this.cmbSourceTablePK.Size = new System.Drawing.Size(208, 21);
			this.cmbSourceTablePK.TabIndex = 35;
			// 
			// cmbTargetTablePK
			// 
			this.cmbTargetTablePK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbTargetTablePK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbTargetTablePK.Enabled = false;
			this.cmbTargetTablePK.ForeColor = System.Drawing.Color.DarkViolet;
			this.cmbTargetTablePK.Location = new System.Drawing.Point(372, 37);
			this.cmbTargetTablePK.Name = "cmbTargetTablePK";
			this.cmbTargetTablePK.Size = new System.Drawing.Size(214, 21);
			this.cmbTargetTablePK.TabIndex = 36;
			// 
			// DBImportSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmbTargetTablePK);
			this.Controls.Add(this.cmbSourceTablePK);
			this.Controls.Add(this.tabCtrlScripts);
			this.Controls.Add(this.cmbSourceTable);
			this.Controls.Add(this.grImportedColumns);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbTargetTable);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Name = "DBImportSettings";
			this.Size = new System.Drawing.Size(1132, 625);
			this.grImportedColumns.ResumeLayout(false);
			this.grImportedColumns.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridColumnsMapping)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsMappingColumns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMappingColumns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbMappingColumns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navMappingColumns)).EndInit();
			this.navMappingColumns.ResumeLayout(false);
			this.navMappingColumns.PerformLayout();
			this.cntxMenuSQLUpdateScript.ResumeLayout(false);
			this.tabCtrlScripts.ResumeLayout(false);
			this.tabScriptResult.ResumeLayout(false);
			this.tabScriptResult.PerformLayout();
			this.tabSQLScriptForDirectUpdate.ResumeLayout(false);
			this.tabCursorScript.ResumeLayout(false);
			this.tabCursorScript.PerformLayout();
			this.tabImportWithRowset.ResumeLayout(false);
			this.tabImportWithRowset.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTargetTable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox grImportedColumns;
		private System.Windows.Forms.Button btnDirectImport;
		private System.Windows.Forms.Button btnGenerateImportScript;
		private System.Windows.Forms.TextBox txtTargetScript;
		private System.Windows.Forms.ComboBox cmbSourceTable;
		private System.Windows.Forms.Button btnApplyUpdateScript;
		private System.Windows.Forms.TabControl tabCtrlScripts;
		private System.Windows.Forms.TabPage tabCursorScript;
		private System.Windows.Forms.TextBox txtSQLCursorScript;
		private System.Windows.Forms.TabPage tabSQLScriptForDirectUpdate;
		private System.Windows.Forms.TabPage tabScriptResult;
		private System.Windows.Forms.DataGridView gridColumnsMapping;
		private System.Windows.Forms.BindingNavigator navMappingColumns;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Data.DataSet dsMappingColumns;
		private System.Data.DataTable tbMappingColumns;
		private System.Windows.Forms.BindingSource bsMappingColumns;
		private System.Windows.Forms.Button btnPrepareImportScript;
		private System.Windows.Forms.TextBox txtResultUpdateScript;
		private System.Windows.Forms.ContextMenuStrip cntxMenuSQLUpdateScript;
		private System.Windows.Forms.TabPage tabImportWithRowset;
		private System.Windows.Forms.TextBox txtRowsetDynamicUpdateSQLScript;
		private System.Windows.Forms.Button btnRunScriptOnTarget;
		private System.Windows.Forms.ComboBox cmbSourceTablePK;
		private System.Windows.Forms.ComboBox cmbTargetTablePK;
		private System.Data.DataColumn colIsKey;
		private System.Data.DataColumn colTargetType;
		private System.Windows.Forms.ToolStripMenuItem miSaveSQLUpdateScript;
		public System.Data.DataColumn colSourceColumn;
		public System.Data.DataColumn colTargetColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn sourceGridViewColumn;
		private System.Windows.Forms.DataGridViewButtonColumn colFunction;
		private System.Windows.Forms.DataGridViewComboBoxColumn targetDataGridViewColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isPKJoinDataGridViewColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn targetTypeDataGridViewColumn;
	}
}
