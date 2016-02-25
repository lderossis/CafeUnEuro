using System;
using CafeUnEuro.Core;
using NUnit.Framework;
using SQLite;
using System.Linq;
using System.Collections.Generic;
using RichardSzalay.MockHttp;
using System.Net.Http;
using CafeUnEuro.Tests;

namespace CafeUnEuro.Tests
{
	public class CoffeeServiceTest
	{
		ICoffeeShopAPIClientFactory _apiClientFactory;
		ICoffeeService _service;

		[SetUp]
		public void Setup()
		{
			var mockApiUrl = new Uri ("http://opendata.paris.fr/api/records/1.0/search/?dataset=liste-des-cafes-a-un-euro");
			var  mockHttp = new MockHttpMessageHandler();

			mockHttp
				.When (mockApiUrl.ToString())

				.Respond ( "application/json", _samplie_json);

			_apiClientFactory = MockHelper.CreateClient (mockHttp);


			_service = new CoffeeService (_apiClientFactory);

		}




		[Test]
		public void Should_retrive_and_map_coffee_shop_from_api()
		{
			var result =  _service.GetList ().Result;

			//	Assert.IsNotNullOrEmpty (result.ElementAt (0).Address);
			Assert.AreEqual("Coffee Chope", result.ElementAt (0).Name);
			//	Assert.IsNotNullOrEmpty (result.ElementAt (0).Id);
		}



		const string _samplie_json =@"
{
    ""format"": ""json"",
    ""nhits"": 1,
    ""records"": [
        {
            ""datasetid"": ""liste-des-cafes-a-un-euro"",
            ""fields"": {
                ""adresse"": ""344 rue Vaugirard"",
                ""arrondissement"": 75015,
                ""date"": ""2014-02-01"",
                ""geoloc"": [
                    48.839471,
                    2.30286
                ],
                ""nom_du_cafe"": ""Coffee Chope"",
                ""prix_comptoir"": 1,
                ""prix_salle"": ""-"",
                ""prix_terasse"": ""-""
            },
            ""geometry"": {
                ""coordinates"": [
                    2.30286,
                    48.839471
                ],
                ""type"": ""Point""
            },
            ""record_timestamp"": ""2016-02-14T23:00:04+00:00"",
            ""recordid"": ""4588e58f447fb4dd5df12eafbaf7d9314decd475""
        }
    ],
    ""rows"": 10,
    ""timezone"": ""UTC""
}		
";
	}
}

