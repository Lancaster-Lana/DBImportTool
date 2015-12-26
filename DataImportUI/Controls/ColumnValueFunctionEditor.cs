
using System.ComponentModel;
using System.Linq;
//using System.Linq.Expressions;
using System.Linq.Expressions;
using System.Windows.Forms;
using DataImportTool.Tools;

namespace DataImportTool.Controls
{
	public partial class ColumnValueFunctionEditor : Form
	{
		#region Properties

		[Browsable(true)]
		[Category("ColumnsDesigner")]
		public string[] Items
		{
			get { return (string[])listColumns.Items.OfType<string>(); }
			set { if (value != null) listColumns.Items.AddRange(value); }
		}

		public ColumnExpression ResultExpression
		{
			get;
			private set;
		}

		/// <summary>
		/// Short description to be displayed as expression for column
		/// </summary>
		public string ResultExpressionString
		{
			get
			{
				return ResultExpression.ToString();
				//return ExpressionHelper.GetColumnExpression(ResultExpression.ColumnName, ResultExpression.Splitter, ResultExpression.ColumnPartNumber);
			}
		}

		#endregion

		#region Ctor

		public ColumnValueFunctionEditor()
		{
			InitializeComponent();
		}

		public ColumnValueFunctionEditor(string[] columns)
			: this()
		{
			this.Items = columns;
		}

		#endregion

		#region Handlers

		private void miCommaSeparator_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();
			char separator = ',';

			using (var positionDialog = new GetColumnPartByPositionDialog(columnName, separator))
			{
				if (positionDialog.ShowDialog() == DialogResult.OK)
				{
					separator = positionDialog.Separator;
					int position = positionDialog.Position;
					ResultExpression = new ColumnExpression(columnName, separator, position);
					txtFunctionExpression.Text = ResultExpressionString;
				}
			}
		}

		private void miSemicolonSeparator_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();
			char separator = ';';

			using (var positionDialog = new GetColumnPartByPositionDialog(columnName, separator))
			{
				if (positionDialog.ShowDialog() == DialogResult.OK)
				{
					separator = positionDialog.Separator;
					int position = positionDialog.Position;
					ResultExpression = new ColumnExpression(columnName, separator, position);
					txtFunctionExpression.Text = ResultExpressionString;
				}
			}
		}

		private void miColumnSeparator_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();
			char separator = '|';
			using (var positionDialog = new GetColumnPartByPositionDialog(columnName, separator))
			{
				if (positionDialog.ShowDialog() == DialogResult.OK)
				{
					separator = positionDialog.Separator;
					int position = positionDialog.Position;
					ResultExpression = new ColumnExpression(columnName, separator, position);
					txtFunctionExpression.Text = ResultExpressionString;
				}
			}
		}

		private void miGetMinfValueOfTheRange_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();
			char separator = '-';
			int position = 0;

			ResultExpression = new ColumnExpression(columnName, separator, position);
			txtFunctionExpression.Text = ResultExpressionString;
		}

		private void miGetMaxfValueOfTheRange_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();
			char separator = '-';
			int position = 1;

			ResultExpression = new ColumnExpression(columnName, separator, position);
			txtFunctionExpression.Text = ResultExpressionString;
		}

		private void miGetSymbolsFromMToNPostionToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();

			int startPosition = 0;
			int endPosition = 1;

			using (var positionDialog = new GetColumnPartFromPositionDialog(columnName, startPosition, endPosition))
			{
				if (positionDialog.ShowDialog() == DialogResult.OK)
				{
					startPosition = positionDialog.StartPosition;
					endPosition = positionDialog.EndPosition;
					ResultExpression = new ColumnExpression(columnName, startPosition, endPosition);
					txtFunctionExpression.Text = ResultExpressionString;
				}
			}
		}

		private void miApplyCustomFunction_Click(object sender, System.EventArgs e)
		{
			if (listColumns.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please, select column", "Select column name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string columnName = listColumns.SelectedItems[0].ToString();

			using (var funcDialog = new CustomColumnFunctionDialog(columnName))
			{
				if (funcDialog.ShowDialog() == DialogResult.OK)
				{
					string function = funcDialog.Function;
					ResultExpression = new ColumnExpression(columnName, function);
					txtFunctionExpression.Text = ResultExpressionString;
				}
			}
		}

		#endregion

	}
}
