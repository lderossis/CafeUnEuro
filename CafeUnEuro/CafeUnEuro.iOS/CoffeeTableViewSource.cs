using System;
using UIKit;
using System.Collections.Generic;
using CafeUnEuro.Core;
using System.Linq;

namespace CafeUnEuro.iOS
{
	public class CoffeeTableViewSource : UITableViewSource
	{
		IEnumerable<CoffeeShop> _coffeeShops;
		const string cellIdentifier = "coffee-shop-cell";

		public CoffeeTableViewSource (IEnumerable<CoffeeShop> Shops)
		{
			_coffeeShops = Shops;
		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (cellIdentifier);
			var coffeeshop = _coffeeShops.ElementAt (indexPath.Row);

			if(cell == null)
			{
				cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellIdentifier);
			}

			cell.TextLabel.Text = coffeeshop.Name;
			cell.DetailTextLabel.Text = coffeeshop.Address;

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _coffeeShops.Count();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		#endregion
	}
}

