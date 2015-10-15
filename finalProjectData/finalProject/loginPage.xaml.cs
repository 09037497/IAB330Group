using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace finalProject
{
	public partial class loginPage : ContentPage
	{
		public loginPage ()
		{
			InitializeComponent ();
		}
		public void onClicked (object sender, EventArgs args) {
			Navigation.PushAsync (new helloPage ());
	}



		//<ImageCell 
		//Text="{Binding Name}" 
		//	Detail="{Binding Position, StringFormat='{0}'}" 
		//	ImageSource="{Binding Image}">
		//	</ImageCell>
    }
}

