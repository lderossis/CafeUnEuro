using System;
using GalaSoft.MvvmLight;

namespace CafeUnEuro.Core
{
	public class LandingViewModel : ViewModelBase
	{
		public LandingViewModel ()
		{
		}

		public string HelloWorld {get {return "Hello from the view model ";}}
	}
}

