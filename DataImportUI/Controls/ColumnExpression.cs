using System;
using System.Collections.Generic;
using System.ComponentModel;
//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;
using Microsoft.JScript;
using Microsoft.JScript.Vsa;

namespace DataImportTool.Tools
{

	public enum ColumnExpressionType
	{
		range = 0, //split column value by '-' and get first\last value
		splitter = 1, //split column value by special symbol, like ',' '|' etc and get partitional value in specific position
		substring = 2, //cut substring from M to N position, espessialy if column is a string
		custom = 3 // apply custom Function to column value
	}

	/// <summary>
	/// Expression to be applied to column value
	/// </summary>
	public class ColumnExpression
	{
		#region Properties

		public string ColumnName { get; set; }

		[DefaultValue(ColumnExpressionType.range)]
		public ColumnExpressionType ExpressionType { get; set; }

		public ColumnExpression Value
		{
			get { return this; }
		}

		[DefaultValue(' ')]
		public char Splitter { get; set; }
		/// <summary>
		/// Number of column's value part after it is splitted by a Splitter
		/// </summary>
		[DefaultValue(1)]
		public int ColumnPartitionNumber { get; set; }

		public int StartPosition { get; set; }
		public int EndPosition { get; set; }

		public string Function { get; set; }

		/// <summary>
		/// Descriptive information to be displayed in column mapping
		/// </summary>
		public string Description
		{
			get
			{
				return ToString();
			}
		}

		#endregion

		#region Ctor

		/// <summary>
		/// Simple column, not expression
		/// </summary>
		/// <param name="columnName"></param>
		public ColumnExpression(string columnName)
		{
			this.ColumnName = columnName;
			this.Splitter = ' ';
			this.ColumnPartitionNumber = -1;
		}

		public ColumnExpression(string columnName, char separator, int position)
		{
			this.ExpressionType = ColumnExpressionType.splitter;

			this.ColumnName = columnName;
			this.Splitter = separator;
			this.ColumnPartitionNumber = position;
		}

		public ColumnExpression(string columnName, int startPosition, int endPosition)
		{
			this.ExpressionType = ColumnExpressionType.substring;

			this.ColumnName = columnName;
			this.StartPosition = startPosition;
			this.EndPosition = endPosition;
		}

		public ColumnExpression(string columnName, string functionExpr)
		{
			this.ExpressionType = ColumnExpressionType.custom;

			this.ColumnName = columnName;
			this.Function = functionExpr;
		}

		#endregion

		/// <summary>
		/// Detect if column is expression or simple column
		/// </summary>
		/// <param name="sourceColumn"></param>
		/// <returns></returns>
		public static ColumnExpression Parce(object sourceColumn)
		{
			return sourceColumn is ColumnExpression ? (ColumnExpression)sourceColumn : new ColumnExpression(sourceColumn.ToString());
		}

		public override string ToString()
		{
			if (ExpressionType == ColumnExpressionType.splitter)
				return string.Format(" SPLIT([{0}], with='{1}', part at POSITION={2})", ColumnName, Splitter, ColumnPartitionNumber);
			if (ExpressionType == ColumnExpressionType.substring)
				return string.Format(" SUBSTRING([{0}], from='{1}', to ={2} position)", ColumnName, StartPosition, EndPosition);
			if (ExpressionType == ColumnExpressionType.custom)
				return string.Format("[{0}] ('{1}')", Function, ColumnName);
			return ColumnName;
		}


		/// <summary>
		/// Calculate result 
		/// </summary>
		/// <param name="sourceColumnExpr"></param>
		/// <param name="columnValue"></param>
		/// <returns></returns>
		public static object GetExpressionResult(ColumnExpression sourceColumnExpr, object columnValue)
		{
			if (sourceColumnExpr.ExpressionType == ColumnExpressionType.splitter)
				return ColumnExpressionHelper.GetColumnPartValueSeparatedBy(columnValue, sourceColumnExpr.Splitter, sourceColumnExpr.ColumnPartitionNumber);

			if (sourceColumnExpr.ExpressionType == ColumnExpressionType.substring)
				return ColumnExpressionHelper.GetColumnPartValue(columnValue, sourceColumnExpr.StartPosition, sourceColumnExpr.EndPosition);

			if (sourceColumnExpr.ExpressionType == ColumnExpressionType.custom)
				return ColumnExpressionHelper.CalculateColumnFunction(columnValue, sourceColumnExpr.Function);

			//if (separator == ' ')
			return columnValue;
		}

	}

	public class ColumnExpressionHelper
	{
		public static string GetColumnPartValueSeparatedBy(object columnValue, char separator, int position)
		{
			IList<string> columnsParts = columnValue.ToString().Split(separator);
			return columnsParts.Count > position ? columnsParts[position] : string.Empty; //TODO:
		}


		public static object GetColumnPartValue(object columnValue, int from, int to)
		{
			if (columnValue == null) return null;

			return columnValue.ToString().PadRight(to).Substring(from, to - from);
		}


		private static VsaEngine _expressionEngine;
		static VsaEngine ExpressionEngine
		{
			get
			{
				if (_expressionEngine == null)
					_expressionEngine = VsaEngine.CreateEngine();

				return _expressionEngine;
			}
		}
		public static object CalculateColumnFunction(object columnValue, string expr)
		{
			//ScriptEngine engine = Python.CreateEngine();
			//return engine.Execute(function);
			return Microsoft.JScript.Convert.ToString(Eval.JScriptEvaluate(expr, ExpressionEngine), true);
		}
	}
}

//public static string GetColumnExpression(string columnName, char separator, int position)
//{
//	//return string.Format(" SUBSTRING([{0}], CHARINDEX('{1}',[{0}])+1, 4)", columnName, separator);
//	return string.Format(" SPLIT( Column=[{0}], by='{1}', getValueAtPostion={2})", columnName, separator, position);
//}