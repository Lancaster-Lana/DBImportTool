using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataImportTool.Controls;
using DataImportTool.Helpers;
using oledb_sql;

namespace DataImportTool.Tools
{
	public partial class DBImportSettings : UserControl
	{

		#region Properties

		private DbConnection _sourceDbConnection;
		public DbConnection SourceDbConnection
		{
			get { return _sourceDbConnection; }
			set
			{
				_sourceDbConnection = value;
				//Fill data to controls;
				if (_sourceDbConnection != null)
				{
					cmbSourceTable.DataSource = _sourceDbConnection.GetDbTablesNames();
					cmbSourceTable.Update();
				}
			}
		}

		private DbConnection _targetDbConnection;
		public DbConnection TargetDbConnection
		{
			get { return _targetDbConnection; }
			set
			{
				_targetDbConnection = value;

				if (_targetDbConnection != null)
				{
					cmbTargetTable.DataSource = _targetDbConnection.GetDbTablesNames();
					cmbTargetTable.Update();
				}
			}
		}


		private List<DataColumn> _sourceTableAllColumns;
		private List<DataColumn> _targetTableAllColumns;


		private string importSQLScript;

		#endregion

		#region Ctor

		public DBImportSettings()
		{
			InitializeComponent();
		}

		public DBImportSettings(DbConnection sourceDbConnection, DbConnection targetDbConnection)
			: this()
		{
			SourceDbConnection = sourceDbConnection;
			TargetDbConnection = targetDbConnection;
		}

		#endregion

		#region Methods

		private Dictionary<ColumnExpression, string> GetColumnsMappings(out Dictionary<string, string> keyColumns)
		{
			keyColumns = new Dictionary<string, string>();

			Dictionary<ColumnExpression, string> columnsMappings = null;

			if (tbMappingColumns != null && tbMappingColumns.Rows.Count > 0)
			{
				columnsMappings = new Dictionary<ColumnExpression, string>();
				foreach (DataRow row in tbMappingColumns.Rows)
				{
					object sourceColumn = row[0]; //NOTE: column name or expression !5
					string targetColumn = row[1].ToString();

					//var newTargetValue = sourceColumn;
					bool isKey = !string.IsNullOrEmpty(row[2].ToString()) && (bool)row[2];
					if (isKey)
						keyColumns.Add(((ColumnExpression)sourceColumn).ColumnName, targetColumn);

					columnsMappings.Add(ColumnExpression.Parce(sourceColumn), targetColumn);
				}
			}
			return columnsMappings;
		}

		private void cmbSourceTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Get source table
			string selectedTableName = Convert.ToString(cmbSourceTable.SelectedItem);

			//clear previous mapping
			tbMappingColumns.Rows.Clear();//gridColumnsMapping.Rows.Clear();

			if (SourceDbConnection == null || string.IsNullOrEmpty(selectedTableName)) return;

			//var table = SourceDbConnection.GetDbTable(selectedTableName);
			_sourceTableAllColumns = SourceDbConnection.GetDbTableColumns(selectedTableName);

			// Fill controls with table columns information
			cmbSourceTablePK.DataSource = _sourceTableAllColumns;
			cmbSourceTablePK.Update();
			DataColumn keyColumn = _sourceTableAllColumns != null && _sourceTableAllColumns.Count > 0 ? _sourceTableAllColumns[0] : null; //TODO:
			cmbSourceTablePK.Text = keyColumn != null ? keyColumn.ColumnName : string.Empty;

			if (_sourceTableAllColumns != null)
			{
				//var columnsWithoutKey = _sourceTableAllColumns.Except(new[] { keyColumn }).ToList();
				var list = _sourceTableAllColumns.Select(c => new ColumnExpression(c.ColumnName)).ToList();
				//sourceGridViewColumn.Items.AddRange(list);
				sourceGridViewColumn.ValueType = typeof(ColumnExpression);
				sourceGridViewColumn.DataSource = list;//_sourceTableAllColumns; //columnsWithoutKey;
				sourceGridViewColumn.DisplayMember = "Description";//"ColumnName";
				sourceGridViewColumn.ValueMember = "Value";
			}
		}

		private void cmbTargetTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Get target table
			string selectedTableName = Convert.ToString(cmbTargetTable.SelectedItem);

			//clear previous mapping
			tbMappingColumns.Rows.Clear();//gridColumnsMapping.Rows.Clear(); 

			if (TargetDbConnection == null || string.IsNullOrEmpty(selectedTableName)) return;

			//var table = TargetDbConnection.GetDbTable(selectedTableName);
			_targetTableAllColumns = TargetDbConnection.GetDbTableColumns(selectedTableName);

			//Fill controls with table columns information
			cmbTargetTablePK.DataSource = _targetTableAllColumns;
			cmbTargetTablePK.Update();
			var keyColumn = _targetTableAllColumns != null && _targetTableAllColumns.Count > 0 ? _targetTableAllColumns[0] : null;
			cmbTargetTablePK.Text = keyColumn != null ? keyColumn.ColumnName : string.Empty;

			if (_targetTableAllColumns != null)
			{
				//var columnsWithoutKey = _targetTableAllColumns.Except(new[] { keyColumn }).ToList();
				//targetDataGridViewColumn.DataSource = _targetTableAllColumns;//columnsWithoutKey;
				//targetDataGridViewColumn.DisplayMember = "ColumnName";
				string[] list = _targetTableAllColumns.Select(c => c.ColumnName).ToArray();
				targetDataGridViewColumn.Items.AddRange(list);
			}
		}

		private void gridColumnsMapping_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			//if (gridColumnsMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//DBNull.Value)
			{
				e.Cancel = false;
			}
		}

		private void gridColumnsMapping_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			/*
			DataGridView senderGrid = (DataGridView)sender;

			var editableCtrl = senderGrid.EditingControl as DataGridViewComboBoxEditingControl;
			var editablePanel = gridColumnsMapping.EditingPanel;
			if (!editablePanel.Controls.Contains(FunctionEditor))
			{
				editablePanel.Controls.Clear();
				editablePanel.Controls.Add(FunctionEditor);
			}*/

			//Custom DropDown control
			if (e.Control is ComboBox)
			{
				var combo = (ComboBox)e.Control;
				combo.DropDownStyle = ComboBoxStyle.DropDown; //to make control editable.

				//============
				//var comboColumn = senderGrid.Columns[senderGrid.CurrentCell.ColumnIndex] as DataGridViewComboBoxColumn;
				//comboColumn.CellTemplate = new DataGridViewTextBoxCell(){ValueType = }
				//combo.SelectedIndexChanged += (o, args) => { };
			}
		}

		private void gridColumnsMapping_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			//If function button clicked
			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				// Button Clicked - Execute Code Here
				string[] sourceColumns = _sourceTableAllColumns.Select(c => c.ColumnName).ToArray();
				var funcEditorDlg = new ColumnValueFunctionEditor(sourceColumns);
				if (funcEditorDlg.ShowDialog() == DialogResult.OK)
				{
					ColumnExpression columnExpression = funcEditorDlg.ResultExpression;

					//Set corespondent column
					var sourceComboColumn = senderGrid.Columns[senderGrid.CurrentCell.ColumnIndex - 1] as DataGridViewComboBoxColumn; //get previous source column
					if (sourceComboColumn != null && !string.IsNullOrWhiteSpace(columnExpression.ColumnName))
					{
						var columnslist = (List<ColumnExpression>)sourceComboColumn.DataSource;
						if (!columnslist.Contains(columnExpression))
						{
							columnslist.Add(columnExpression);// sourceComboColumn.Items.Add(columnExpression);
							sourceGridViewColumn.DataSource = columnslist;
						}
						senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = columnExpression;
					}
				}
			}
		}

		private void gridColumnsMapping_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			//var value = gridColumnsMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			var value = e.FormattedValue is ColumnExpression ? (ColumnExpression)e.FormattedValue : null;//gridColumnsMapping.CurrentCell.EditedFormattedValue;
			var senderGrid = (DataGridView)sender;
			var comboColumn = //sourceComboColumn sourceGridViewColumn
				senderGrid.Columns[gridColumnsMapping.CurrentCell.ColumnIndex] as DataGridViewComboBoxColumn;

			if (comboColumn != null && value != null)// && value != "")
			{
				var columnslist = (List<ColumnExpression>)comboColumn.DataSource;

				//if (!comboColumn.Items.Contains(value)) 
				if (!columnslist.Contains(value))
				{
					//comboColumn.Items.Add(value);
					columnslist.Add(value);
					sourceGridViewColumn.DataSource = columnslist;
				}

				senderGrid.CurrentCell.Value = value;
			}
		}

		private void gridColumnsMapping_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var currentRow = gridColumnsMapping.Rows[e.RowIndex];
			var currentCell = currentRow.Cells[e.ColumnIndex];
			/*
						//1. check if such mapping exists already
						if (tbMappingColumns.Rows.Count > 0)
						{
							var matchMapping = tbMappingColumns.Rows.Cast<DataRow>()
																		.FirstOrDefault(r => r[e.ColumnIndex].Equals(currentCell.Value));
							currentRow.ErrorText = matchMapping != null
																		? "Please choose anotner column for mapping. The  iscolumn [" + currentCell.Value + " ] in use already"
																		: string.Empty;
						}
			*/
			//2. check if target column type equals to a source one
			if (e.ColumnIndex == 2 && _targetTableAllColumns != null)
			{
				//get source (1st) column to detect its type
				var sourceCell = currentRow.Cells[0];
				DataColumn sourceColumn = _sourceTableAllColumns.FirstOrDefault(c => c.ColumnName == sourceCell.Value.ToString());

				if (sourceColumn == null) return;

				Type sourceType = sourceColumn.DataType;

				var targetCell = currentRow.Cells[2]; // or currentCell
				DataColumn targetColumn = _targetTableAllColumns.FirstOrDefault(c => c.ColumnName == targetCell.Value.ToString());

				if (targetColumn == null) return;

				Type targetType = targetColumn.DataType;
				currentRow.Cells[4].Value = targetType.Name;

				currentRow.ErrorText = !(targetType == sourceType) ? "Target COLUMN TYPE (" + targetType.Name + ") mismatch to source column tupe (" + sourceType.Name + ")" : string.Empty;
			}
		}

		private void btnPrepareImportScript_Click(object sender, EventArgs e)
		{
			if (gridColumnsMapping.Rows.Count == 0)
			{
				MessageBox.Show("Please enter columns to be updated in target DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string sourceDBFile = SourceDbConnection.Database;
			object sourceTableName = cmbSourceTable.SelectedItem;
			string sourceTablePK = cmbSourceTablePK.Text;
			object sourceImportField = gridColumnsMapping.Rows[0].Cells[0];

			string targetDB = TargetDbConnection.Database;
			object targetTableName = cmbTargetTable.SelectedItem;
			string targetTablePK = cmbTargetTablePK.Text;
			var targetImportField = gridColumnsMapping.Rows[0].Cells[1];

			bool isKeyField = (bool)gridColumnsMapping.Rows[0].Cells[2].Value;

			var dynamicQuery = string.Format(txtSQLCursorScript.Text,
																			targetDB, targetTableName, targetTablePK, targetImportField,
																			sourceDBFile, sourceTableName, sourceTablePK, sourceImportField);

			txtSQLCursorScript.Text = dynamicQuery; //OledbToSqlHelper.GenerateUpdateScript_ADODBCursor(); //dynamicQuery;

			//var result = TargetDbConnection.ExecuteDynamicQuery(dynamicQuery);
		}

		private void btnGenerateImportScript_Click(object sender, EventArgs e)
		{
			//string sourceDBFile = SourceDbConnection.Database;
			string sourceDBConnection = _sourceDbConnection.ConnectionString;
			string sourceTableName = Convert.ToString(cmbSourceTable.SelectedItem);

			if (string.IsNullOrWhiteSpace(sourceTableName)) return;

			var sourceTablePKs = cmbSourceTablePK.Text; //(IList<string>)lstSourceTablePK.DataSource;
			//string sourceImportField = gridColumnsMapping.Rows[0].Cells[0];

			//var targetDB = TargetDbConnection.Database;
			string targetTableName = Convert.ToString(cmbTargetTable.SelectedItem);
			var targetTablePKs = cmbTargetTablePK.Text;//(IList<string>)lstTargetTablePK.DataSource;

			//GENERATE update script for target DB
			Dictionary<string, string> PKeysMapping;
			Dictionary<ColumnExpression, string> columnsMappings = GetColumnsMappings(out PKeysMapping);

			importSQLScript = OledbToSqlHelper.GenerateImportScript_OleDBtoSqlServer(sourceDBConnection, sourceTableName, targetTableName, PKeysMapping, columnsMappings);

			txtTargetScript.Text = importSQLScript;
		}

		private void btnApplyUpdateScript_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				string importScript = txtTargetScript.Text;
				string msg = TargetDbConnection.ExecNonSQLQuery(importScript);
				if (string.IsNullOrEmpty(msg))
				{
					MessageBox.Show("Import success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (MessageBox.Show("Import fail. Show error log?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
					{
						txtResultUpdateScript.Text = msg;
					}
				}
			}
		}

		private void btnDirectImport_Click(object sender, EventArgs e)
		{
			string sourceTbl = cmbSourceTable.SelectedItem.ToString();
			string targetTbl = cmbTargetTable.SelectedItem.ToString();

			// PKs and columns mapping
			Dictionary<string, string> mappingKeys;
			Dictionary<ColumnExpression, string> columnsMapping = GetColumnsMappings(out mappingKeys);
			string oleDbSQL = String.Format("SELECT * FROM [{0}]", sourceTbl); //sourceTbl;

			//do import
			OledbToSqlHelper.DirectImportDataFromOleDbToSqlServer(SourceDbConnection.ConnectionString, oleDbSQL,
																														TargetDbConnection.ConnectionString, targetTbl, columnsMapping);
		}


		private void miSaveSQLUpdateScript_Click(object sender, EventArgs e)
		{
			using (var saveDialog = new SaveFileDialog())
			{
				saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				saveDialog.FilterIndex = 2;
				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveDialog.FileName, importSQLScript);
				}
			}
		}

		#endregion

		#region IMPORT WITH OPENROWSET

		/// <summary>
		/// TODO: Generate OPENROWSET script
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabImportWithRowset_Enter(object sender, EventArgs e)
		{
			//var oleDbConnectionString = txtSourceDBFile.Text; //oleDbConnectionString = ExpandConnectionStringFileName(oleDbConnectionString);
			string sourceTableName = cmbSourceTable.SelectedItem as string;
			string sourceTablePK = cmbSourceTablePK.Text;
			//var oleDbSQL = txtDynamicUpdateSQLScript.Text;

			//var sqlConnectionString = txtSQLServerConnStr.Text;
			//var sqlDb = TargetDbConnection.Database;
			//var sqlTableName = cmbTargetTable.Text;
			//var sqlServerKey = "Employer";

			txtRowsetDynamicUpdateSQLScript.Text = String.Format(txtRowsetDynamicUpdateSQLScript.Text, sourceTableName);
		}

		private void btnRunScriptOnTarget_Click(object sender, EventArgs e)
		{
			string openrowsetSQL = txtRowsetDynamicUpdateSQLScript.Text;

			//do import with openrowset
			TargetDbConnection.ExecNonSQLQuery(openrowsetSQL);
		}

		#endregion
	}
}