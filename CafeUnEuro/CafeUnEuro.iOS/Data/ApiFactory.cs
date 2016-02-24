using System;
using CafeUnEuro.Core;

namespace CafeUnEuro.iOS
{
	public class ApiFactory : ICoffeeShopAPIClientFactory
	{
		public ApiFactory ()
		{
		}

		#region ICoffeeShopAPIClientFactory implementation

		public System.Net.Http.HttpMessageHandler GetHttpClient ()
		{
			return new ModernHttpClient.NativeMessageHandler ();
		}

		public Uri ApiUrl {
			get {
				return new Uri ("http://opendata.paris.fr/api/records/1.0/search/?dataset=liste-des-cafes-a-un-euro");
			}
		}

		#endregion
	}
}

