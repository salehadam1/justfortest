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
	public partial class Museum : ContentPage
	{
		public Museum ()
		{
			InitializeComponent ();
		}

        private void Eyre_Square_Clicked(object sender, EventArgs e)
        {           
                Navigation.PushAsync(new Eyre_Square());
        }

        private void Galway_Market_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new galway_Market());
        }

        private void Galway_Cathedral_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Galway_Cathedral());
        }

        private void Galway_Museum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new galway_City_Museum());
        }

        private void Fortest_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}