using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using GalaSoft.MvvmLight.Views;
using CafeUnEuro.Core;
using CoreLocation;
using MapKit;

namespace CafeUnEuro.iOS
{
	partial class DetailController : ControllerBase
	{
		public DetailController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var coffeeShop = this.NavigationParameter as CoffeeShop;
			if(coffeeShop != null)
			{
				lblName.Text = coffeeShop.Name;
				lblAddress.Text = coffeeShop.Address;

				this.mapView.AddAnnotation (new BasicMapAnnotation(coffeeShop));

				//var coords = new CLLocationCoordinate2D (coffeeShop.Coordinates.Longitude, coffeeShop.Coordinates.Latitude);
				//var span = new MKCoordinateSpan(MilesToLatitudeDegrees(2), )
			}
		}
	}
}
