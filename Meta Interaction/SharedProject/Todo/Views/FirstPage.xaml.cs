using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Todo
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();

		}

		public void try1 (object sender, EventArgs e)
		{
			//Navigation.PushAsync (new Event());
			Navigation.PushAsync (new MainView());
			//Navigation.PushModalAsync(new TodoListPage());
			// new Event();
		}


	}
}

