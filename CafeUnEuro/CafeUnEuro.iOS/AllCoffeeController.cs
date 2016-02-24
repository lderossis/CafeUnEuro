using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CafeUnEuro.iOS
{
	partial class AllCoffeeController : UIViewController
	{
		public AllCoffeeController (IntPtr handle) : base (handle)
		{
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if(segue.Identifier == "detailCoffeeSegue")
			{
				var test = textName.Text;
			}
		}
	}
}
