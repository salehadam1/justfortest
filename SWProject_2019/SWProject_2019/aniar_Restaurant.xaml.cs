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
	public partial class aniar_Restaurant : ContentPage
	{
		public aniar_Restaurant ()
		{
			InitializeComponent ();
		}

        private void Anir_Menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu_Aniar());
        }

        private void Anir_link_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.aniarrestaurant.ie/");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restaurants());
        }
    }
}