using System;
using System.Windows.Input;
using Xamarin.Forms;
using employee.Data.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace Employee.Data
{
	public class ProjectDetailViewModel :ViewModelBase
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
			var database = new EmployeeDatabase();
			SaveNoteCommand = new Command (() => {
				database.InsertOrUpdateNote(new Employee(EmployeeName,DateTime.Now.ToString(),EmployeeAvailebleTime.ToString(),EmployeePosition));
				navigationService.GoBack();
			});
		}


	}
}

