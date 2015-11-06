using System;
using Xamarin.Forms;

namespace Todo
{
	public class TodoItemCell : ViewCell
	{
		public TodoItemCell ()
		{
			// BackgroundColor = Color.Aqua;

			var label = new Label {
				YAlign = TextAlignment.Center
			};

			label.SetBinding (Label.TextProperty, "Name");

			var tick = new Image {
				Source = FileImageSource.FromFile ("check2.png")
			};
				tick.SetBinding (Image.IsVisibleProperty, "Done");
			//tick.SetBinding (Image.IsVisibleProperty, "Remarks");

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = { label, tick }
			};

			View = layout;
		}

		protected override void OnBindingContextChanged ()
		{
			

			View.BindingContext = BindingContext;
			base.OnBindingContextChanged ();
		}
	}
}

