using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace finalProject
{
	public partial class helloPage : ContentPage
	{
		public helloPage ()
		{
			InitializeComponent ();
		}
		public void ButtonToCalender (object sender, EventArgs args) {
			Navigation.PushAsync (new calenderPage ());
	}
}
}

