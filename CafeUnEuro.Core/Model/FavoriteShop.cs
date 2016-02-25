using System;
using SQLite;

namespace CafeUnEuro.Core
{
	public class FavoriteShop
	{
		public FavoriteShop ()
		{
			
		}

		[PrimaryKey]
		public string ID {get; set;}
	}
}

