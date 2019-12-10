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
	public partial class galway_Market : ContentPage
	{
		public galway_Market ()
		{
			InitializeComponent ();
		}

        private void Galway_markets_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Galway+Christmas+Market/@53.2745868,-9.0521182,17z/data=!3m1!4b1!4m5!3m4!1s0x485b9799b8d0c8fd:0xdd54ccf8ec0ebabd!8m2!3d53.2745836!4d-9.0499295");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museum());
        }
    }
}