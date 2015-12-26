namespace DataImportTool.Controls
{
	partial class ColumnValueFunctionEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnValueFunctionEditor));
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grbFunction = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFunctionExpression = new System.Windows.Forms.TextBox();
			this.tbColumnFunction = new System.Windows.Forms.ToolStrip();
			this.menuRangeGetValue = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnGetMinfValueOfTheRange = new System.Windows.Forms.ToolStripMenuItem();
			this.btnGetMaxfValueOfTheRange = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSymbolSplitter = new System.Windows.Forms.ToolStripDropDownButton();
			this.miCommaSeparator = new System.Windows.Forms.ToolStripMenuItem();
			this.miSemicolonSeparator = new System.Windows.Forms.ToolStripMenuItem();
			this.miColumn = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCustomColumnFunction = new System.Windows.Forms.ToolStripDropDownButton();
			this.miGetSymbolsFromMToNPostionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miApplyCusomFunction = new System.Windows.Forms.ToolStripMenuItem();
			this.listColumns = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.tbColumnFunction.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(14, 140);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Save";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(95, 140);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// grbFunction
			// 
			this.grbFunction.Location = new System.Drawing.Point(12, 78);
			this.grbFunction.Name = "grbFunction";
			this.grbFunction.Size = new System.Drawing.Size(496, 100);
			this.grbFunction.TabIndex = 3;
			this.grbFunction.TabStop = false;
			this.grbFunction.Text = "groupBox1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFunctionExpression);
			this.groupBox1.Controls.Add(this.tbColumnFunction);
			this.groupBox1.Controls.Add(this.listColumns);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(0, 12);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(598, 111);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please, select column and function to be applied to";
			// 
			// txtFunctionExpression
			// 
			this.txtFunctionExpression.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFunctionExpression.Location = new System.Drawing.Point(329, 16);
			this.txtFunctionExpression.Multiline = true;
			this.txtFunctionExpression.Name = "txtFunctionExpression";
			this.txtFunctionExpression.ReadOnly = true;
			this.txtFunctionExpression.Size = new System.Drawing.Size(266, 92);
			this.txtFunctionExpression.TabIndex = 7;
			// 
			// tbColumnFunction
			// 
			this.tbColumnFunction.Dock = System.Windows.Forms.DockStyle.Left;
			this.tbColumnFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRangeGetValue,
            this.menuSymbolSplitter,
            this.menuCustomColumnFunction});
			this.tbColumnFunction.Location = new System.Drawing.Point(196, 16);
			this.tbColumnFunction.Name = "tbColumnFunction";
			this.tbColumnFunction.Size = new System.Drawing.Size(133, 92);
			this.tbColumnFunction.TabIndex = 6;
			// 
			// menuRangeGetValue
			// 
			this.menuRangeGetValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuRangeGetValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGetMinfValueOfTheRange,
            this.btnGetMaxfValueOfTheRange});
			this.menuRangeGetValue.Image = ((System.Drawing.Image)(resources.GetObject("menuRangeGetValue.Image")));
			this.menuRangeGetValue.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuRangeGetValue.Name = "menuRangeGetValue";
			this.menuRangeGetValue.Size = new System.Drawing.Size(130, 19);
			this.menuRangeGetValue.Text = "Get range value (-)";
			this.menuRangeGetValue.ToolTipText = "Split column value with \'-\'. And get first\\second part";
			// 
			// btnGetMinfValueOfTheRange
			// 
			this.btnGetMinfValueOfTheRange.Name = "btnGetMinfValueOfTheRange";
			this.btnGetMinfValueOfTheRange.Size = new System.Drawing.Size(198, 22);
			this.btnGetMinfValueOfTheRange.Text = "Get Min (first) Value";
			this.btnGetMinfValueOfTheRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGetMinfValueOfTheRange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnGetMinfValueOfTheRange.ToolTipText = "Get Min Value Of The range";
			this.btnGetMinfValueOfTheRange.Click += new System.EventHandler(this.miGetMinfValueOfTheRange_Click);
			// 
			// btnGetMaxfValueOfTheRange
			// 
			this.btnGetMaxfValueOfTheRange.Name = "btnGetMaxfValueOfTheRange";
			this.btnGetMaxfValueOfTheRange.Size = new System.Drawing.Size(198, 22);
			this.btnGetMaxfValueOfTheRange.Text = "Get Max (second) Value";
			this.btnGetMaxfValueOfTheRange.Click += new System.EventHandler(this.miGetMaxfValueOfTheRange_Click);
			// 
			// menuSymbolSplitter
			// 
			this.menuSymbolSplitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuSymbolSplitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCommaSeparator,
            this.miSemicolonSeparator,
            this.miColumn});
			this.menuSymbolSplitter.Image = ((System.Drawing.Image)(resources.GetObject("menuSymbolSplitter.Image")));
			this.menuSymbolSplitter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuSymbolSplitter.Name = "menuSymbolSplitter";
			this.menuSymbolSplitter.Size = new System.Drawing.Size(130, 19);
			this.menuSymbolSplitter.Text = "Split value by symbol";
			this.menuSymbolSplitter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.menuSymbolSplitter.ToolTipText = "Split column with separator char and get one valu array";
			// 
			// miCommaSeparator
			// 
			this.miCommaSeparator.Name = "miCommaSeparator";
			this.miCommaSeparator.Size = new System.Drawing.Size(159, 22);
			this.miCommaSeparator.Text = ", (comma)";
			this.miCommaSeparator.Click += new System.EventHandler(this.miCommaSeparator_Click);
			// 
			// miSemicolonSeparator
			// 
			this.miSemicolonSeparator.Name = "miSemicolonSeparator";
			this.miSemicolonSeparator.Size = new System.Drawing.Size(159, 22);
			this.miSemicolonSeparator.Text = "; (semi-column)";
			this.miSemicolonSeparator.Click += new System.EventHandler(this.miSemicolonSeparator_Click);
			// 
			// miColumn
			// 
			this.miColumn.Name = "miColumn";
			this.miColumn.Size = new System.Drawing.Size(159, 22);
			this.miColumn.Text = "| (column)";
			this.miColumn.Click += new System.EventHandler(this.miColumnSeparator_Click);
			// 
			// menuCustomColumnFunction
			// 
			this.menuCustomColumnFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.menuCustomColumnFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGetSymbolsFromMToNPostionToolStripMenuItem,
            this.miApplyCusomFunction});
			this.menuCustomColumnFunction.Image = ((System.Drawing.Image)(resources.GetObject("menuCustomColumnFunction.Image")));
			this.menuCustomColumnFunction.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuCustomColumnFunction.Name = "menuCustomColumnFunction";
			this.menuCustomColumnFunction.Size = new System.Drawing.Size(130, 19);
			this.menuCustomColumnFunction.Text = "Column Function";
			this.menuCustomColumnFunction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.menuCustomColumnFunction.ToolTipText = "Function to be applied on value of the column";
			// 
			// miGetSymbolsFromMToNPostionToolStripMenuItem
			// 
			this.miGetSymbolsFromMToNPostionToolStripMenuItem.Name = "miGetSymbolsFromMToNPostionToolStripMenuItem";
			this.miGetSymbolsFromMToNPostionToolStripMenuItem.Size = new System.Drawing.Size(340, 22);
			this.miGetSymbolsFromMToNPostionToolStripMenuItem.Text = "Get symbols from m to n postion";
			this.miGetSymbolsFromMToNPostionToolStripMenuItem.Click += new System.EventHandler(this.miGetSymbolsFromMToNPostionToolStripMenuItem_Click);
			// 
			// miApplyCusomFunction
			// 
			this.miApplyCusomFunction.Name = "miApplyCusomFunction";
			this.miApplyCusomFunction.Size = new System.Drawing.Size(340, 22);
			this.miApplyCusomFunction.Text = "Apply function (sin, cos, tan, etc.) to column value";
			this.miApplyCusomFunction.Click += new System.EventHandler(this.miApplyCustomFunction_Click);
			// 
			// listColumns
			// 
			this.listColumns.Dock = System.Windows.Forms.DockStyle.Left;
			this.listColumns.FormattingEnabled = true;
			this.listColumns.Location = new System.Drawing.Point(3, 16);
			this.listColumns.Name = "listColumns";
			this.listColumns.Size = new System.Drawing.Size(193, 92);
			this.listColumns.TabIndex = 5;
			// 
			// ColumnValueFunctionEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 186);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ColumnValueFunctionEditor";
			this.Text = "Column function";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tbColumnFunction.ResumeLayout(false);
			this.tbColumnFunction.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox grbFunction;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFunctionExpression;
		private System.Windows.Forms.ToolStrip tbColumnFunction;
		private System.Windows.Forms.ToolStripDropDownButton menuRangeGetValue;
		private System.Windows.Forms.ToolStripMenuItem btnGetMinfValueOfTheRange;
		private System.Windows.Forms.ToolStripMenuItem btnGetMaxfValueOfTheRange;
		private System.Windows.Forms.ToolStripDropDownButton menuSymbolSplitter;
		private System.Windows.Forms.ToolStripMenuItem miCommaSeparator;
		private System.Windows.Forms.ToolStripMenuItem miSemicolonSeparator;
		private System.Windows.Forms.ToolStripMenuItem miColumn;
		private System.Windows.Forms.ListBox listColumns;
		private System.Windows.Forms.ToolStripDropDownButton menuCustomColumnFunction;
		private System.Windows.Forms.ToolStripMenuItem miGetSymbolsFromMToNPostionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miApplyCusomFunction;
	}
}