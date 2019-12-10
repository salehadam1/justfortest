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
	public partial class Loam_Rest : ContentPage
	{
		public Loam_Rest ()
		{
			InitializeComponent ();
		}

        private void Loam_Menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu_loam());
        }

        private void Loam_link_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://loamgalway.com/");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restaurants());
        }
    }
}