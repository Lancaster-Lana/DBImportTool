namespace DataImportUI
{
	using System.Collections.Generic;
	using System.Data;
	using System.Data.Common;

	internal class SettingsManager
	{
		static DataTable __providersTable;
		public static DataTable ProvidersTable
		{
			get
			{
				if (__providersTable == null)
					__providersTable = DbProviderFactories.GetFactoryClasses();
				return __providersTable;
			}
		}

		public static List<string> ProvidersListOnHot
		{
			get
			{
				var provInvariantNames = new List<string>();

				DataTable installedProviders = ProvidersTable;
				foreach (DataRow provRow in installedProviders.Rows)
				{
					string provInvariantName = provRow.ItemArray[2].ToString();
					string assemblyLib = provRow.ItemArray[3].ToString();

					//try to get 
					var dbFactory = DbProviderFactories.GetFactory(provInvariantName);
					provInvariantNames.Add(provInvariantName);
				}
				return provInvariantNames;
			}
		}
	}
}

