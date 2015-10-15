using System;
using GalaSoft.MvvmLight;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace finalProjectData
{
	/// <summary>
	/// This class contains properties that the main View can data bind to.
	/// <para>
	/// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
	/// </para>
	/// <para>
	/// You can also use Blend to data bind with the tool's support.
	/// </para>
	/// <para>
	/// See http://www.galasoft.ch/mvvm
	/// </para>
	/// </summary>
	public class EmployeeListViewModel : ViewModelBase
	{
		private IMyNavigationService navigationService;

		private ObservableCollection<employee> employeeList;

		public ObservableCollection<employee> EmployeeList {
			get { return employeeList; }
			set { employeeList = value;
				RaisePropertyChanged (() => EmployeeList); }
		}





		public ICommand NewNoteCommand { get; private set; }
		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public EmployeeListViewModel(IMyNavigationService navigationService)
		{
			this.navigationService = navigationService;
			//var database = new EmployeeDataBase ();
			NewNoteCommand = new Command (() => this.navigationService.NavigateTo (ViewModelLocator.EmployeeDetailPageKey));
		}

		public void OnAppearing(){
			var database = new EmployeeDataBase ();
			EmployeeList = new ObservableCollection<employee> (database.GetAll ());
		}

	}
}