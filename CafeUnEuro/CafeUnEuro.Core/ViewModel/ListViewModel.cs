using System;
using GalaSoft.MvvmLight;

namespace CafeUnEuro.Core
{
	public class ListViewModel : ViewModelBase
	{
		public ListViewModel (ICoffeeService CoffeeService, IFavorisService FavorisService)
		{
			_coffeeService = CoffeeService;
			_favorisService = FavorisService;
		}

		private ICoffeeService _coffeeService;
		private IFavorisService _favorisService;


		public void DetailCommand(CoffeeShop ChosenItem)
		{
			
		}
	}
}

