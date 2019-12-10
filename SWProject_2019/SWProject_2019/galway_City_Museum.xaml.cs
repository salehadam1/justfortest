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
	public partial class galway_City_Museum : ContentPage
	{
		public galway_City_Museum ()
		{
			InitializeComponent ();
		}

        private void Galway_MU_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Galway+City+Museum/@53.2696822,-9.0558038,17z/data=!3m1!4b1!4m5!3m4!1s0x485b96fb41beccb3:0x3aae7c7716a45a9f!8m2!3d53.2696822!4d-9.0536151");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museum());
        }
    }
}