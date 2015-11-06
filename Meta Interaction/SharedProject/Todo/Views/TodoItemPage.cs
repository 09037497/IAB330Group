using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Todo
{
	public class TodoItemPage : ContentPage
	{
		public TodoItemPage ()
		{
			BackgroundColor = Color.Aqua;


			this.SetBinding (ContentPage.TitleProperty, "Name");

			NavigationPage.SetHasNavigationBar (this, true);
			var nameLabel = new Label { Text = "Staff Name" };
			var nameEntry = new Entry ();
			//nameLabel = Color.Red;
			//nameEntry = Color.Yellow;
			
			nameEntry.SetBinding (Entry.TextProperty, "Name");

			var notesLabel = new Label { Text = "Skills" };
			var notesEntry = new Entry ();
			notesEntry.SetBinding (Entry.TextProperty, "Notes");


			var doneLabel = new Label { Text = "Remarks" };
			var doneEntry = new Xamarin.Forms.Switch ();
			doneEntry.SetBinding (Xamarin.Forms.Switch.IsToggledProperty, "Done");
			/*
			var doneLabel = new Label { Text = "Remarks" };
			var doneEntry = new Xamarin.Forms.Switch ();
			doneEntry.SetBinding (Xamarin.Forms.Switch.IsToggledProperty, "Remarks");
			*/
			var saveButton = new Button { Text = "Save" };
			saveButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.SaveItem (todoItem);
				Navigation.PopAsync ();
			};

			var deleteButton = new Button { Text = "Delete" };
			deleteButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.DeleteItem (todoItem.ID);
				Navigation.PopAsync ();
			};
							
			var cancelButton = new Button { Text = "Cancel" };
			cancelButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				Navigation.PopAsync ();
			};

			/*
			var speakButton = new Button { Text = "Speak" };
			speakButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				DependencyService.Get<ITextToSpeech> ().Speak (todoItem.Name + " " + todoItem.Notes);
			};*/

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (20),
				Children = {
					nameLabel, nameEntry, 
					notesLabel, notesEntry,
					doneLabel, doneEntry,
					saveButton, deleteButton, cancelButton,
					//speakButton
				}
			};
		}
	}
}