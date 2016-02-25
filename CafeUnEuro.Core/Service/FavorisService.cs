using System;

namespace CafeUnEuro.Core
{
	public class FavorisService : IFavorisService
	{
		private readonly IDBProvider _dbProvider;

		public FavorisService (IDBProvider DBProvider)
		{
			_dbProvider = DBProvider;
		}

		#region IFavorisService implem_entation
		public void AddToFavorite (string coffeeShopId)
		{
			_dbProvider.GetDatabaseInstance ().Insert (new FavoriteShop{ ID = coffeeShopId });
		}

		public void RemoveFromFavorite (string IDCoffee)
		{
			_dbProvider.GetDatabaseInstance ().Delete<FavoriteShop> (IDCoffee);
		}

		public bool CheckFavoriteStatus (string IDCoffee)
		{
			var fav = _dbProvider.GetDatabaseInstance ().Find<FavoriteShop> (shop => shop.ID == IDCoffee);
			return fav != null;
		}

		public System.Collections.Generic.IEnumerable<FavoriteShop> GetFavoriteList ()
		{
			return _dbProvider.GetDatabaseInstance ()
				.Query<FavoriteShop> ("select * from FavoriteShop");
		}
		#endregion
	}
}

