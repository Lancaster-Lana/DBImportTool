using System.Windows.Forms;

namespace DataImportTool.Controls
{
	public partial class GetColumnPartByPositionDialog : Form
	{
		public string ColumnName {
			get { return txtColumnName.Text; }
			set { txtColumnName.Text =value; }
		}

		public char Separator
		{
			get { return  string.IsNullOrEmpty(cmbSplitter.Text) ? ' ' : cmbSplitter.Text[0]; }
			set { cmbSplitter.Text = value.ToString(); }
		}

		public int Position
		{
			get { return (int)spinPosition.Value; }
			set { spinPosition.Value = value; }
		}

		public GetColumnPartByPositionDialog()
		{
			InitializeComponent();
		}

		public GetColumnPartByPositionDialog(string columnName, char separator) : this()
		{
			this.ColumnName = columnName;
			this.Separator = separator;
		}
	}
}
