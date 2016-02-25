using System;

namespace CafeUnEuro.Core
{
	public class CoffeeShopApiClientFactory : ICoffeeShopAPIClientFactory
	{
		public CoffeeShopApiClientFactory ()
		{
		}

		#region ICoffeeShopAPIClientFactory implementation

		public Uri ApiUrl {
			get {
				throw new NotImplementedException ();
			}
		}

		public System.Net.Http.HttpMessageHandler GetHttpClient ()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

