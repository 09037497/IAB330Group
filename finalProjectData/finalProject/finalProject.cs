using System;

using Xamarin.Forms;
using finalProjectData;
using GalaSoft.MvvmLight.Ioc;

namespace finalProject
{
	public class App : Application
	{
		private static NavigationService nav;

		private static ViewModelLocator _locator;

		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator());
			}
		}
		public App ()
		{
			
			nav = new NavigationService ();
			nav.Configure (ViewModelLocator.EmployeeDetailPageKey, typeof(staffPage));
			nav.Configure (ViewModelLocator.EmployeeListPageKey, typeof(staffPage));

			SimpleIoc.Default.Register<IMyNavigationService> (()=> nav, true);
			var navPage = new NavigationPage (new loginPage ());
			navPage.Title ="staff";
			nav.Initialize (navPage);
			MainPage = navPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

