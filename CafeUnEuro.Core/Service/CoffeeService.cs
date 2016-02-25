using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;

namespace CafeUnEuro.Core
{
	public class CoffeeService : ICoffeeService
	{
		//private readonly IDBProvider _dbProvider;
		private readonly ICoffeeShopAPIClientFactory _apiClientFactory;

		public CoffeeService (ICoffeeShopAPIClientFactory apiClientFactory)
		{
			_apiClientFactory = apiClientFactory;
		}

		#region ICoffeeService implementation

		public async Task<IEnumerable<CoffeeShop>> GetList ()
		{
			/*HttpMessageHandler client = _apiClientFactory.GetHttpClient ();

			string result = await client.GetStringAsync (_apiUrl);

			return result.MapToCoffeeShop ();*/

			using (var client = new HttpClient (_apiClientFactory.GetHttpClient ()))
			{
				var jsonCoffeeShopResult = await client.GetStringAsync (_apiClientFactory.ApiUrl.ToString ());
				return jsonCoffeeShopResult.MapToCoffeeShop ();
			}
		}

		#endregion
	}
}

