using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace layouts
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            Title = "Main page";
			InitializeComponent();
            var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = 20 };
            var label1 = new Label {Text="Digite nombre: " };
            var text1 = new Entry {Placeholder="name" };
            var seleccion = new Picker { };
            var opciones = new List<int>();
            opciones.Add(3);
            opciones.Add(5);
            opciones.Add(10);
            seleccion.ItemsSource = opciones;
            var boton = new Button { Text = "comenzar" };
            this.Content = layout;

            layout.Children.Add(label1);
            layout.Children.Add(text1);
            layout.Children.Add(seleccion);
            layout.Children.Add(boton);
            
            boton.Clicked += delegate
            {
                Navigation.PushAsync(new second(Int32.Parse(seleccion.Items[seleccion.SelectedIndex]), Int32.Parse(seleccion.Items[seleccion.SelectedIndex]), text1.Text.ToString() ));
            };


        }
        
        
    }
}
