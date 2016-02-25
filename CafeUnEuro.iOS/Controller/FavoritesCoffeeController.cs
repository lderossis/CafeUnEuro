using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CafeUnEuro.Core;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace CafeUnEuro.iOS
{
	partial class FavoritesCoffeeController : UIViewController
	{
		ObservableTableViewController<CoffeeShop> _controller;

		public FavoritesCoffeeController (IntPtr handle) : base (handle)
		{	
		}

		private ListViewModel _viewModel;
		public ListViewModel ViewModel{
			get{_viewModel = _viewModel ?? ServiceLocator.Current.GetInstance <ListViewModel> ();
				return _viewModel;}
		}

		private INavigationService _navigationService;
		protected INavigationService NavigationService
		{
			get{_navigationService = _navigationService ?? ServiceLocator.Current.GetInstance <INavigationService>();
				return _navigationService;}
		}



		public async override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			await this.ViewModel.InitVM ();

			_controller = ViewModel.CoffeeShops.GetController (CreateCell, UpdateCell);

			_controller.TableView = coffeeTableView;

			_controller.SelectionChanged += (object sender, EventArgs e) => 
			{
				if(NavigationService != null)
				{
					NavigationService.NavigateTo ("DetailController", _controller.SelectedItem);
				}
			};

		}

		UITableViewCell CreateCell(NSString cellidentifier)
		{
			return new UITableViewCell (UITableViewCellStyle.Subtitle, "coffee-shop-cell");
		}

		void UpdateCell(UITableViewCell cell, CoffeeShop shop, NSIndexPath indexPath)
		{
			cell.TextLabel.Text = shop.Name;
			cell.DetailTextLabel.Text = shop.Address;
		}

	}
}
