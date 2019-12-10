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
    public partial class Eyre_Square : ContentPage
    {
        public Eyre_Square()
        {
            InitializeComponent();
        }

        private void Eyre_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Eyre+Square,+Galway/@53.2747105,-9.0508674,17z/data=!3m1!4b1!4m5!3m4!1s0x485b96ef7ce9c957:0xc9b451744a91bbfe!8m2!3d53.2747105!4d-9.0486787");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museum());
        }
    }
}