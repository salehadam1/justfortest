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
	public partial class Nightlife : ContentPage
	{
		public Nightlife ()
		{
			InitializeComponent ();
		}

        private void Taaffes_Bar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new the_TaaffesBar());
        }

        private void Tig_Coili_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new theTig_Coili());
        }

        private void The_Front_Door_Clicked(object sender, EventArgs e)
        {           
                Navigation.PushAsync(new TheFront_Door());
        }

        private void The_Quays_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheQuays_bar());
        }

        private void Fortest_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}