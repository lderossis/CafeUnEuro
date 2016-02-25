using System;
using System.Net.Http;

namespace CafeUnEuro.Core
{
	public interface ICoffeeShopAPIClientFactory
	{
		HttpMessageHandler GetHttpClient();

		Uri ApiUrl { get;}
	}
}

