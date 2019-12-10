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
	public partial class the_TaaffesBar : ContentPage
	{
		public the_TaaffesBar ()
		{
			InitializeComponent ();
		}

        private void Galway_taaff_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Taaffes+Bar/@53.2723487,-9.0531715,15z/data=!4m5!3m4!1s0x0:0x4d06d9fe3e283e18!8m2!3d53.2723487!4d-9.0531715?hl=en-IE");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nightlife());
        }
    }
}