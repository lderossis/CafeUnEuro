// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CafeUnEuro.iOS
{
	[Register ("AllCoffeeController")]
	partial class AllCoffeeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton openButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (openButton != null) {
				openButton.Dispose ();
				openButton = null;
			}
			if (textName != null) {
				textName.Dispose ();
				textName = null;
			}
		}
	}
}
