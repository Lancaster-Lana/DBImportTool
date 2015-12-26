using System.Windows.Forms;

namespace DataImportTool.Controls
{
	public partial class GetColumnPartFromPositionDialog : Form
	{
		public string ColumnName
		{
			get { return txtColumnName.Text; }
			set { txtColumnName.Text = value; }
		}

		public int StartPosition
		{
			get { return (int) spinStartPosition.Value; }
			set { spinStartPosition.Value = value; }
		}

		public int EndPosition
		{
			get { return (int)spinEndPosition.Value; }
			set { spinEndPosition.Value = value; }
		}

		public GetColumnPartFromPositionDialog()
		{
			InitializeComponent();
		}

		public GetColumnPartFromPositionDialog(string columnName, int startPosition, int endPosition) : this()
		{
			this.ColumnName = columnName;
			this.StartPosition = startPosition;
			this.EndPosition = endPosition;
		}
	}
}

