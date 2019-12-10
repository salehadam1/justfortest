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
	public partial class Restaurants : ContentPage
	{
		public Restaurants ()
		{
			InitializeComponent ();
		}

        private void The_Dough_Bros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheDough_Bros());
        }

        private void Ard_Bia_at_Nimmos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ard_atNimmos());
        }

        private void Aniar_Restaurant_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new aniar_Restaurant());
        }

        private void Loam_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loam_Rest());
        }

        private void Fortest_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}