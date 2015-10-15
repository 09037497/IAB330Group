/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:finalProjectData"
/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:NoteTaker1.Data"
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

namespace finalProjectData
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
	{
		public const string EmployeeListPageKey = "EmployeeListPage";
		public const string EmployeeDetailPageKey = "EmployeeDetailPage";
		/// <summary>
		/// Initializes a new instance of the ViewModelLocator class.
		/// </summary>
		public ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			////if (ViewModelBase.IsInDesignModeStatic)
			////{
			////    // Create design time view services and models
			////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
			////}
			////else
			////{
			////    // Create run time view services and models
			////    SimpleIoc.Default.Register<IDataService, DataService>();
			////}

			SimpleIoc.Default.Register<EmployeeListViewModel>(() => 
				{
					return new EmployeeListViewModel(
						SimpleIoc.Default.GetInstance<IMyNavigationService>()
					);
				});
			SimpleIoc.Default.Register<EmployeeDetailViewModel>(() => 
				{
					return new EmployeeDetailViewModel(
						SimpleIoc.Default.GetInstance<IMyNavigationService>()
					);
				});
		}

		public EmployeeListViewModel EmployeeListVM
		{
			get
			{
				return ServiceLocator.Current.GetInstance<EmployeeListViewModel>();
			}
		}

		public EmployeeDetailViewModel EmployeeDetailVM
		{
			get
			{
				return ServiceLocator.Current.GetInstance<EmployeeDetailViewModel> ();
			}
		}
		public static void Cleanup()
		{
			// TODO Clear the ViewModels
		}
	}
}