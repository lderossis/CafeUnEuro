using System;
using CafeUnEuro.Core;
using SQLite;

namespace CafeUnEuro.droid
{
	public class DBProvider : IDBProvider
	{
		private SQLiteConnection _dbConnection;

		public DBProvider ()
		{
			_dbConnection = new SQLiteConnection ("ma_db_locale");
		}

		#region IDBProvider implementation

		public SQLiteConnection GetDatabaseInstance ()
		{
			return _dbConnection;
		}

		#endregion
	}
}

