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

		double Longitude
		{
			get;
			set;
		}

		double Latitude 
		{
			get;
			set;
		}
	}
}

