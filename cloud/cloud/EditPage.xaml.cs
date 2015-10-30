using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Forms;

namespace cloud
{
	public partial class EditPage : ContentPage
	{
		private Employ employ;

		public EditPage (Employ employ)
		{
			InitializeComponent ();
			this.employ = employ;

			ActualizarButton.Clicked += ActualizarButton_Clicked;
			BorrarButton.Clicked += BorrarButton_Clicked;

			nombresEntry.Text = empleado.Nombres;
			apelliodsEntry.Text = empleado.Apellidos;
			salarioEntry.Text = empleado.Salario.ToString();
			nombresEntry.Text = empleado.Nombres;
			fechaContratoDatePicker.Date = empleado.FechaContrato;
			activoSwitch.IsToggled = Employ.Activo;
				
		}

		public async void BorrarButton_Clicked(object sender, EventArgs e)
		{
			var rta = await DisplayAlert("Confirmation", "Hi borrar", "Yes", "No");
			if (!rta) return;

			using (var datos = new DataAccess())
			{
				datos.DeleteEmploy(employ);
			}

			await DisplayAlert("Confirmation", "Employ borrad", "aceptar");
			await Navigation.PushAsync(new HomePage());
				
		}

		public async void ActualizarButton_Clicked(object sender, EventArgs e)
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
				IDEmploy = this.employ.IDEmploy(),
				Activo = activoSwitch.IsToggled,
				Apellidos =  apellidosEntry.Text,
				FechaContrato = fechaContratoDatePicker.Date,
				Nombres = nombresEntry.Text,
				Salario = decimal.Parse(salaryioEntry.Text)

			};

			using (var datos = new DataAccess ()) 
			{
				datos.UpdateEmploy (employ);
				//datosListView.ItemsSource = datos.GetEmploy ();
			}

		}
	}
}

