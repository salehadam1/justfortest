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
	public partial class TheQuays_bar : ContentPage
	{
		public TheQuays_bar ()
		{
			InitializeComponent ();
		}

        private void Galway_Quays_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/The+Quays+Bar+and+Restaurant/@53.2710966,-9.0561305,17z/data=!3m1!4b1!4m5!3m4!1s0x485b96fb20daf785:0x36e633c4b8c1c2c7!8m2!3d53.2710966!4d-9.0539418?hl=en-IE");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nightlife());
        }
    }
}