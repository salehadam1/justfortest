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
	public partial class theTig_Coili : ContentPage
	{
		public theTig_Coili ()
		{
			InitializeComponent ();
		}

        private void Galway_Tig_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Tig+Coili/@53.2723554,-9.0557169,17z/data=!3m1!4b1!4m5!3m4!1s0x485b96fac5a4634d:0xc988c438bd20355a!8m2!3d53.2723554!4d-9.0535282?hl=en-IE");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nightlife());
        }
    }
}