using System;
using Xamarin.Forms;
using Android.App;
using Android.OS;
//using Performance_Shared;
using Android.Views;

namespace Todo
{
	public class MainView : TabbedPage
	{
		public MainView ()
		{

			BackgroundColor = Color.Aqua;

			//FirstPage.Icon  = ImageSource.Resource("square1.png");
			//TodoListPage.Icon = ImageSource.FromFile("circle1.png");

		

					
			this.Children.Add (new TodoListPage (){ Title = "Staff List", Icon="square1.png"});
			this.Children.Add (new Calender (){ Title = "Calender", Icon="circle1.png"});
			this.Children.Add (new Location (){ Title = "Location", Icon="square1.png"});
			this.Children.Add (new Contactus (){ Title = "Contact Us", Icon="circle1.png"});
				
				this.Title="Main Page";


		}
	}
}

