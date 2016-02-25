using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CafeUnEuro.Core;
using Microsoft.Practices.ServiceLocation;

namespace CafeUnEuro.iOS
{
	partial class AllCoffeeController : UIViewController
	{
		private ListViewModel _viewModel;
		public ListViewModel ViewModel{
			get{return _viewModel = _viewModel ?? ServiceLocator.Current.GetInstance <ListViewModel> ();}
		}

		public AllCoffeeController (IntPtr handle) : base (handle)
		{
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if(segue.Identifier == "detailCoffeeSegue")
			{
				//var test = textName.Text;
			}
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.ViewModel.InitVM ();
		}


	}
}
