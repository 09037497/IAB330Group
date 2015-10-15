using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace finalProject
{
	public partial class contactPage : ContentPage
	{
		public contactPage ()
		{
			InitializeComponent ();
		}
		public void ButtonToLogin (object sender, EventArgs args) {
			Navigation.PushAsync (new loginPage ());
		}
	}
}

