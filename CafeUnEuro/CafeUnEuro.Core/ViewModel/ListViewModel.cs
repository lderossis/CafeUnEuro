using System;
using GalaSoft.MvvmLight;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Views;

namespace CafeUnEuro.Core
{
	public class ListViewModel : ViewModelBase
	{
		private readonly ICoffeeService _coffeeService;
		private readonly IFavorisService _favorisService;

		private readonly INavigationService _navigationService;

		public ObservableCollection<CoffeeShop> CoffeeShops { get; private set;}

		public ListViewModel (ICoffeeService CoffeeService, IFavorisService FavorisService, INavigationService NavigationService)
		{
			_coffeeService = CoffeeService;
			_favorisService = FavorisService;
			_navigationService = NavigationService;
		}

		public async Task InitVM()
		{
			if(CoffeeShops != null && CoffeeShops.Any ())
			{
				return;
			}
			var allcoffees = await _coffeeService.GetList ();

			if(allcoffees.Any())
			{
				CoffeeShops = new ObservableCollection<CoffeeShop>(allcoffees);
			}
		}

		public void DetailCommand(CoffeeShop ChosenItem)
		{
			
		}
	}
}

