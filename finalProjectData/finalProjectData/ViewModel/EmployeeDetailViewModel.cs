using System;
using System.Windows.Input;
using Xamarin.Forms;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight;


namespace finalProjectData
{
	public class EmployeeDetailViewModel :ViewModelBase
	{
		public ICommand SaveNoteCommand { get; private set;}
		private String employeeName;

		public String EmployeeName
		{
			get { return employeeName; }
			set { employeeName = value;
				RaisePropertyChanged(() => EmployeeName); }
		}

		private string employeePosition;

		public string EmployeePosition
		{
			get { return employeePosition; }
			set { employeePosition = value;
				RaisePropertyChanged(() => employeePosition); }
		}

		private bool employeeAvailableTime;

		public bool EmployeeAvailableTime
		{
			get { return employeeAvailableTime; }
			set { employeeAvailableTime = value;
				RaisePropertyChanged(() => employeeAvailableTime); }
		}


		public EmployeeDetailViewModel (IMyNavigationService navigationService)
		{
			var database = new EmployeeDataBase();
			SaveNoteCommand = new Command (() => {
				database.InsertOrUpdateNote(new employee(EmployeeName,EmployeePosition,EmployeeAvailableTime.ToString()));
				navigationService.GoBack();
			});
		}


	}
}

