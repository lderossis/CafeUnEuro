using System;
using SQLite;

namespace CafeUnEuro.Core
{
	public interface IDBProvider
	{
		SQLiteConnection GetDatabaseInstance();
	}
}

