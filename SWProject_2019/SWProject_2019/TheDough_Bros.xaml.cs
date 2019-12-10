using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWProject_2019
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TheDough_Bros : ContentPage
	{
		public TheDough_Bros ()
		{
			InitializeComponent ();
		}

        private void The_dough_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restaurants());
        }

        private void Eyre_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.thedoughbros.ie/");
            Device.OpenUri(uri);
        }

        private void Menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheDough_Menu());
        }
    }
}