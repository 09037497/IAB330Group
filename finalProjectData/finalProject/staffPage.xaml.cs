using System;
using System.Collections.Generic;
using finalProjectData;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace finalProject
{
	public partial class staffPage : ContentPage
	{
		public staffPage ()
		{
			BindingContext = App.Locator.EmployeeListVM;
			InitializeComponent ();

		}

		protected override void OnAppearing(){
			base.OnAppearing ();
			var vm = ServiceLocator.Current.GetInstance<EmployeeListViewModel> ();
			vm.OnAppearing();

		}

	}


}


