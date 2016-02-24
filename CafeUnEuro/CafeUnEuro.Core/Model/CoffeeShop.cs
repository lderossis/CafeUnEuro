using System;

namespace CafeUnEuro.Core
{
	public class CoffeeShop
	{
		public CoffeeShop ()
		{
		}

		public string ID {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public string Address {
			get;
			set;
		}

		public Coordinate Coordinates {
			get;
			set;
		}

		public int District {
			get;
			set;
		}
	}
}

