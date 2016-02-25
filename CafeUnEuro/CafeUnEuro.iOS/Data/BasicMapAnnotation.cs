using System;
using MapKit;
using CafeUnEuro.Core;
using CoreLocation;

namespace CafeUnEuro.iOS
{
	public class BasicMapAnnotation : MKAnnotation
	{
		CoffeeShop shop;
		CLLocationCoordinate2D _coords;

		public BasicMapAnnotation (CoffeeShop Shop)
		{
			shop = Shop;
			_coords = new CLLocationCoordinate2D (shop.Coordinates.Longitude, shop.Coordinates.Latitude);
		}

		#region implemented abstract members of MKAnnotation

		public override CoreLocation.CLLocationCoordinate2D Coordinate {
			get {
				return _coords;
			}
		}

		public override string Title {
			get {
				return shop.Name;
			}
		}

		public override string Subtitle {
			get {
				return shop.Address;
			}
		}

		#endregion
	}
}

