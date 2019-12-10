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
	public partial class Ard_atNimmos : ContentPage
	{
		public Ard_atNimmos ()
		{
			InitializeComponent ();
		}

        private void Bia_Menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArdNimmos_Menu());
        }

        private void Bia_link_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("http://www.ardbia.com/");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restaurants());
        }
    }
}