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
	public partial class TheFront_Door : ContentPage
	{
		public TheFront_Door ()
		{
			InitializeComponent ();
		}

        private void Galway_door_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/The+Front+Door/@53.2716955,-9.0541576,15z/data=!4m5!3m4!1s0x0:0x17fe4b6348d2b20c!8m2!3d53.2716955!4d-9.0541576?hl=en-IE");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nightlife());
        }
    }
}