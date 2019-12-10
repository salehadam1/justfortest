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
	public partial class Hotel : ContentPage
	{
		public Hotel ()
		{
			InitializeComponent ();
		}

        private void The_g_Hotel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new the_gHotel());
        }

        private void Glenlo_Abbey_Clicked(object sender, EventArgs e)
        {           
             Navigation.PushAsync(new Glenlo_Abbey());
        }

        private void Jurys_Inn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jurys_In());
        }

        private void The_Connacht_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Connacht());
        }

        private void Fortest_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}