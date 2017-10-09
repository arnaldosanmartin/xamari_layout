using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class second : ContentPage
	{
		public second (int totalr, int actualr, string name)
		{
            Title = actualr.ToString() + " de " + totalr.ToString();
			InitializeComponent ();
            Random ram = new Random();
            int digt1 = ram.Next(0 , 10);
            int digt2 = ram.Next(0 , 10);
            int sig = ram.Next(0 , 2);
            int resp = 0;

            int win = 0;

            var layout = new StackLayout { Orientation = StackOrientation.Vertical, Margin = 20 };
            var label = new Label {FontSize=24, HorizontalTextAlignment= TextAlignment.Center};
            if (sig==0)
            {
                label.Text =digt1.ToString() + " + " + digt2.ToString();
                resp = digt1 + digt2;
            }
            else
            {
                label.Text = digt1.ToString() + " - " + digt2.ToString();
                resp = digt1 - digt2;
            }
            var text = new Entry { };
            var boton = new Button { Text = "Check" };

            boton.Clicked += delegate
            {
                actualr--;
                Title = actualr.ToString() + " de " + totalr.ToString();
                if (Int32.Parse(text.Text) == resp)
                {
                    win++;
                }
                if (actualr==0)
                {
                    Navigation.PopAsync();
                    DisplayAlert("Resultados de "+ name,"Acerto "+ win.ToString()+" de "+ totalr.ToString(),"Ok");
                }
                else
                {
                    
                    digt1 = ram.Next(0, 10);
                    digt2 = ram.Next(0, 10);
                    sig = ram.Next(0, 2);
                    resp = 0;
                    if (sig == 0)
                    {
                        label.Text = digt1.ToString() + " + " + digt2.ToString();
                        resp = digt1 + digt2;
                    }
                    else
                    {
                        label.Text = digt1.ToString() + " - " + digt2.ToString();
                        resp = digt1 - digt2;
                    }

                    text.Text = "";
                }
            };


            layout.Children.Add(label);
            layout.Children.Add(text);
            layout.Children.Add(boton);

            this.Content = layout;
        }
	}
}