namespace DataImportTool.Controls
{
	partial class GetColumnPartByPositionDialog
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbSplitter = new System.Windows.Forms.ComboBox();
			this.txtColumnName = new System.Windows.Forms.TextBox();
			this.spinPosition = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.spinPosition)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(61, 93);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(142, 93);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Column name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Splitted by";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Get value in Position :";
			// 
			// cmbSplitter
			// 
			this.cmbSplitter.FormattingEnabled = true;
			this.cmbSplitter.Items.AddRange(new object[] {
            ",",
            ";",
            "|"});
			this.cmbSplitter.Location = new System.Drawing.Point(145, 30);
			this.cmbSplitter.Name = "cmbSplitter";
			this.cmbSplitter.Size = new System.Drawing.Size(72, 21);
			this.cmbSplitter.TabIndex = 5;
			// 
			// txtColumnName
			// 
			this.txtColumnName.Location = new System.Drawing.Point(145, 6);
			this.txtColumnName.Name = "txtColumnName";
			this.txtColumnName.ReadOnly = true;
			this.txtColumnName.Size = new System.Drawing.Size(211, 20);
			this.txtColumnName.TabIndex = 6;
			// 
			// spinPosition
			// 
			this.spinPosition.Location = new System.Drawing.Point(145, 56);
			this.spinPosition.Name = "spinPosition";
			this.spinPosition.Size = new System.Drawing.Size(55, 20);
			this.spinPosition.TabIndex = 8;
			// 
			// GetColumnPartByPosition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 128);
			this.Controls.Add(this.spinPosition);
			this.Controls.Add(this.txtColumnName);
			this.Controls.Add(this.cmbSplitter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "GetColumnPartByPosition";
			this.Text = "Get column value separated by splitter in a selected position";
			((System.ComponentModel.ISupportInitialize)(this.spinPosition)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbSplitter;
		private System.Windows.Forms.TextBox txtColumnName;
		private System.Windows.Forms.NumericUpDown spinPosition;
	}
}