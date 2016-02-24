using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CafeUnEuro.Core;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Helpers;

namespace CafeUnEuro.iOS
{
	partial class LandingViewController : UIViewController
	{
		private LandingViewModel _viewModel;
		protected LandingViewModel ViewModel
		{
			get {return _viewModel = _viewModel ?? ServiceLocator.Current.GetInstance <LandingViewModel>();}
		}

		public LandingViewController (IntPtr handle) : base (handle)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.SetBinding (() => ViewModel.HelloWorld, () => landingLabel.Text);
		}

	}
}
