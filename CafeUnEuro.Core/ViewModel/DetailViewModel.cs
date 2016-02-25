using System;
using GalaSoft.MvvmLight;

namespace CafeUnEuro.Core
{
	public class DetailViewModel : ViewModelBase
	{
		public DetailViewModel (IFavorisService FavorisService)
		{
			_favorisService = FavorisService;
		}

		private IFavorisService _favorisService;

		public CoffeeShop CurrentCS {
			get;
			set;
		}

		bool isFavorite(CoffeeShop CurrentCS)
		{
			return _favorisService.CheckFavoriteStatus (CurrentCS.ID);
		}

		void AddOrRemove(CoffeeShop CurrenCS)
		{
			bool isFavorite = _favorisService.CheckFavoriteStatus (CurrentCS.ID);

			if (isFavorite)
				_favorisService.RemoveFromFavorite (CurrenCS.ID);
			else
				_favorisService.AddToFavorite (CurrenCS.ID);
		}
	}
}

