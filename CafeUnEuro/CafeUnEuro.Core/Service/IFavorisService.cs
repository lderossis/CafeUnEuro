using System;
using System.Collections.Generic;

namespace CafeUnEuro.Core
{
	public interface IFavorisService
	{
		void AddToFavorite(string IDCoffee);
		void RemoveFromFavorite(string IDCoffee);
		bool CheckFavoriteStatus(string IDCoffee);
		IEnumerable<FavoriteShop> GetFavoriteList();
	}
}

