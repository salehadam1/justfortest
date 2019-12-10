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
	public partial class Galway_Cathedral : ContentPage
	{
		public Galway_Cathedral ()
		{
			InitializeComponent ();
		}

        private void Galway_CAth_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.com/maps/place/Galway+Cathedral/@53.275144,-9.0597209,17z/data=!3m1!4b1!4m5!3m4!1s0x0:0xd1d28cae4a94419b!8m2!3d53.275144!4d-9.0575322");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museum());
        }
    }
}