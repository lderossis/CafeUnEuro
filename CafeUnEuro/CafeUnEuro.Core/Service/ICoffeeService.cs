using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CafeUnEuro.Core
{
	public interface ICoffeeService
	{
		Task<IEnumerable<CoffeeShop>> GetList();
	}
}

