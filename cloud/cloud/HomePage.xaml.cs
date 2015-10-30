using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace cloud
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

			nuevoButton.Clicked += nuevoButton_Clikced;
			datosListView.ItemSelected += DatosListView_ItemSelected;


			datosListView.ItemTemplate = new DataTemplate (typeof(EmployCell));

			using (var datos = new DataAccess ()) 
			{
				datosListView.ItemsSource = datos.GetEmploy ();
			}
		}

		void DatosListView_ItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			Navigation.PushAsync (new EditPage ((Empleado)e.SelectedItem));
		}

		public async void nuevoButton_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty (nombresEntry.Text)) 
			{
				await DisplayAlert ("Error", "Debe add numbers", "Aceptar");
				nombresEntry.Focus ();
				return;
			}

			if (string.IsNullOrEmpty (apellidosEntry.Text)) 
			{
				await DisplayAlert ("Error", "Debe add apellidos", "Aceptar");
				apellidosEntry.Focus ();
				return;
			}

			if (string.IsNullOrEmpty (salarioEntry.Text)) 
			{
				await DisplayAlert ("Error", "Debe add salario", "Aceptar");
				salarioEntry.Focus ();
				return;
			}

			Employ = Employ = new Employ 
			{
				Activo = activoSwitch.IsToggled,
				Apellidos =  apellidosEntry.Text,
				FechaContrato = fechaContratoDatePicker.Date,
				Nombres = nombresEntry.Text,
				Salario = decimal.Parse(salaryioEntry.Text)
				
			};

			using (var datos = new DataAccess ()) 
			{
				datos.InsertEmploy (employ);
				datosListView.ItemsSource = datos.GetEmploy ();
			}

			apellidosEntry.Text = string.Empty;
			fechaContratoDatePicker.Date = DateTime.Now;
			nombresEntry.Text = string.Empty;
			salaryioEntry.Text = string.Empty;
			await DisplayAlert ("Mensaje", "Employ creado correctamente", "Aceptar");

		}
	}
}

