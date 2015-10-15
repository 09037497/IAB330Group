using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace finalProject
{
	public partial class calenderPage : ContentPage
	{
		public calenderPage ()
		{
			InitializeComponent ();
		}
		public void ButtonToStaff (object sender, EventArgs args) {
			Navigation.PushAsync (new staffPage ());
		}
		public void ButtonToLocation (object sender, EventArgs args) {
			Navigation.PushAsync (new locationPage ());
		}
	}
}

