/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CafeUnEuro.iOS"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using CafeUnEuro.Core;

namespace CafeUnEuro.iOS.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			SimpleIoc.Default.Register<IDBProvider, DBProvider> ();
			SimpleIoc.Default.Register<ICoffeeService, CoffeeService> ();
			SimpleIoc.Default.Register<IFavorisService, FavorisService> ();
			SimpleIoc.Default.Register<ICoffeeShopAPIClientFactory, ApiFactory> ();

			SimpleIoc.Default.Register<LandingViewModel> ();

        }


        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}