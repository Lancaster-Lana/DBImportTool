namespace DataImportTool.Controls
{
	partial class GetColumnPartFromPositionDialog
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtColumnName = new System.Windows.Forms.TextBox();
			this.spinStartPosition = new System.Windows.Forms.NumericUpDown();
			this.spinEndPosition = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.spinStartPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEndPosition)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(31, 76);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(112, 76);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Get value from:";
			// 
			// txtColumnName
			// 
			this.txtColumnName.Location = new System.Drawing.Point(112, 6);
			this.txtColumnName.Name = "txtColumnName";
			this.txtColumnName.ReadOnly = true;
			this.txtColumnName.Size = new System.Drawing.Size(211, 20);
			this.txtColumnName.TabIndex = 6;
			// 
			// spinStartPosition
			// 
			this.spinStartPosition.Location = new System.Drawing.Point(112, 35);
			this.spinStartPosition.Name = "spinStartPosition";
			this.spinStartPosition.Size = new System.Drawing.Size(55, 20);
			this.spinStartPosition.TabIndex = 8;
			// 
			// spinEndPosition
			// 
			this.spinEndPosition.Location = new System.Drawing.Point(253, 35);
			this.spinEndPosition.Name = "spinEndPosition";
			this.spinEndPosition.Size = new System.Drawing.Size(55, 20);
			this.spinEndPosition.TabIndex = 10;
			this.spinEndPosition.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(173, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "to position :";
			// 
			// GetColumnPartFromPositionDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 111);
			this.Controls.Add(this.spinEndPosition);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.spinStartPosition);
			this.Controls.Add(this.txtColumnName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "GetColumnPartFromPositionDialog";
			this.Text = "Get column part";
			((System.ComponentModel.ISupportInitialize)(this.spinStartPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinEndPosition)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtColumnName;
		private System.Windows.Forms.NumericUpDown spinStartPosition;
		private System.Windows.Forms.NumericUpDown spinEndPosition;
		private System.Windows.Forms.Label label4;
	}
}