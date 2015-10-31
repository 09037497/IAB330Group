using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloud
{
	public class EmployCell
	{
		class EmployCell: ViewCell
		{
			public EmployCell()
			{
				var IDEmployLabel = new Label
				{
					TextColor = Color.White,
					Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
					HorizontalOptions = LayoutOptions.Start
					
				};

				IDEmployLabel.SetBinding(Label.TextProperty, new Binding("IDEmploy"));

				var NombresLabel = new Label
				{
					TextColor = Color.White,
					Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
					HorizontalOptions = LayoutOptions.Fill

				};

				NombresLabel.SetBinding(Label.TextProperty, new Binding("Nombres"));

				var ApellidosLabel = new Label
				{
					TextColor = Color.White,
					Font = Font.BoldSystemFontOfSize(NamedSize.Large),
					HorizontalOptions = LayoutOptions.Fill

				};

				ApellidosLabel.SetBinding(Label.TextProperty, new Binding("Apellidos"));

				var SalarioLabel = new Label
				{
					TextColor = Color.White,
					Font = Font.BoldSystemFontOfSize(NamedSize.Large),
					HorizontalOptions = LayoutOptions.FillAndExpand

				};

				SalarioLabel.SetBinding(Label.TextProperty, new Binding("Salario"));

				var FechaContratoLabel = new Label
				{
					TextColor = Color.White,
					Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
					HorizontalOptions = LayoutOptions.FillAndExpand

				};

				FechaContratoLabel.SetBinding(Label.TextProperty, new Binding("FechaContrato"));


				var ActivoSwitch = new Switch
				{
					HorizontalOptions =LayoutOptions.End
						IsEnabled =false

				};

				ActivoSwitch.SetBinding(Switch.ISToggledProperty, new Binding("Activo"));

				var panel1 = new StackLayout
				{
					children = {SalarioLabel, FechaContratoLabel, ActivoSwitch},
					Orientation = StackOrientation.Horizontal	
				};

				var panel2 = new StackLayout
				{
					children = {SalarioLabel, FechaContratoLabel, ActivoSwitch},
					Orientation = StackOrientation.Horizontal	
				};


				View = new StackLayout
				{
					children = {panel1, panel2},
					Orientation = StackOrientation.Vertical
						VerticalOptions = LayoutOptions.Fill
				};


		}
	}
}

