using System;

namespace CafeUnEuro.Core
{
	public class Coordinate
	{
		public Coordinate (double Longitude, double Latitude)
		{
			this.Longitude = Longitude;
			this.Latitude = Latitude;
		}

		public double Longitude
		{
			get;
			set;
		}

		public double Latitude 
		{
			get;
			set;
		}
	}
}

