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
	public partial class the_gHotel : ContentPage
	{
        public the_gHotel()
        {
            InitializeComponent();
        }
        private void G_calculator_Clicked(object sender, EventArgs e)
        {
            //varabil for the ID plane
           int ID1 = 150;
            int ID2 = 100;
            int ID3 = 800;
            // get the input from the user and save them in float
            float ID = (float)Convert.ToDecimal(g_Id.Text);
            float nuwOfnig = (float)Convert.ToDecimal(numOfnight.Text);
            float numOfpep = (float)Convert.ToDecimal(numOfpepole.Text);
            // sum calculator the total of the price
            float sum;
            // if statements for check and get the total price by useing the ID plane that the user enter
            // plan 1
            if (ID == 1)
            {
                sum = nuwOfnig * numOfpep * ID1;
                 g_Answer.Text = " € " + sum.ToString();
            }
            //plan 2
            else if (ID == 2)
            {
              sum = nuwOfnig * numOfpep * ID2;
               g_Answer.Text = " € " + sum.ToString();
            }
            //plan3
            else if (ID == 3)
            {
               sum = nuwOfnig * (numOfpep / 2) * ID3;
               g_Answer.Text = " € " + sum.ToString();
            }
            // else if the user enter any number then the plan Id that i give the message will show up with invalid Id
            else
            {
                g_Answer.Text = "Sory invalid ID";
            }
           
        }
        // button link to the hotel web
        private void G_Holink_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.theghotel.ie/");
            Device.OpenUri(uri);
        }
        //button link to the hotel in google map
        private void G_Malink_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/The+g+Hotel+%26+Spa/@53.2816715,-9.0343278,17z/data=!3m1!4b1!4m8!3m7!1s0x485b96c62e0cfe29:0x1d56036a16d92a91!5m2!4m1!1i2!8m2!3d53.2816715!4d-9.0321391");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hotel());
        }
    }
}