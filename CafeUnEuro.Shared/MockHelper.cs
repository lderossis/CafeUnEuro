using System;
using CafeUnEuro.Core;
using System.Net.Http;
using SQLite;

namespace CafeUnEuro.Tests
{
	public class MockCoffeeShopApiClientFactory : ICoffeeShopAPIClientFactory
	{
		#region ICoffeeShopApiClientFactory implementation

		public Uri ApiUrl {
			get {
				return new Uri ("http://opendata.paris.fr/api/records/1.0/search/?dataset=liste-des-cafes-a-un-euro");
			}
		}

		HttpMessageHandler _messageHandlerToUse;

		public MockCoffeeShopApiClientFactory (HttpMessageHandler messageHandlerToUse)
		{
			_messageHandlerToUse = messageHandlerToUse;
		}

		public HttpMessageHandler GetHttpClient ()
		{
			return _messageHandlerToUse;
		}
		#endregion
		/*
	
		public System.Net.Http.HttpClient CreateApiClient ()
		{
			return new System.Net.Http.HttpClient (_messageHandlerToUse);
		}*/

	}


	public class MockDbProvider: IDBProvider
	{
		#region IDbProvider implementation

		SQLiteConnection _dbToReturn;

		public MockDbProvider (SQLiteConnection dbToReturn)
		{
			_dbToReturn = dbToReturn;
		}

		public SQLiteConnection GetDatabaseInstance ()
		{
			return _dbToReturn;
		}

		#endregion


	}

	public static class MockHelper
	{

		public static ICoffeeShopAPIClientFactory CreateClient(HttpMessageHandler messageHandlerToUse)
		{
			return new MockCoffeeShopApiClientFactory(messageHandlerToUse);
		}

		public static IDBProvider CreateDbProvider(SQLiteConnection databaseToReturn)
		{
			return new MockDbProvider (databaseToReturn);
		}
	}
}