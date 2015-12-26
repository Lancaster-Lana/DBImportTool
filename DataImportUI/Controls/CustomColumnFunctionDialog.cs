using System.Windows.Forms;

namespace DataImportTool.Controls
{
	public partial class CustomColumnFunctionDialog : Form
	{
		public string ColumnName
		{
			get { return txtColumnName.Text; }
			set { txtColumnName.Text = value; }
		}

		public string Function
		{
			get { return cmbFunction.Text; }
			set { cmbFunction.Text = value; }
		}

		public CustomColumnFunctionDialog()
		{
			InitializeComponent();
		}

		public CustomColumnFunctionDialog(string columnName)//, string functionName)
			: this()
		{
			this.ColumnName = columnName;
			//this.Function = functionName;
		}
	}
}

