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
	public partial class Glenlo_Abbey : ContentPage
	{
		public Glenlo_Abbey ()
		{
			InitializeComponent ();
		}

        private void Gl_calculator_Clicked(object sender, EventArgs e)
        {
            //varabil for the ID plane
            int ID1 = 580;
            int ID2 = 230;
            int ID3 = 230;
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
            // plan 2
            else if (ID == 2)
            {
                sum = nuwOfnig * numOfpep * ID2;
                g_Answer.Text = " € " + sum.ToString();
            }
            // plan 3
            else if (ID == 3)
            {
                sum = nuwOfnig * (numOfpep / 2) * ID3;
                g_Answer.Text = " € " + sum.ToString();
            }
            // else if the user enter any number then the plan Id that i give the message will show up with invalid Id
            else
            {
                g_Answer.Text = "Sory invlid ID";
            }
        }
        // button link to the hotel web
        private void Gl_Holink_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.glenloabbeyhotel.ie/");
            Device.OpenUri(uri);
        }
        //button link to the hotel in google map
        private void Gl_Malink_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.google.ie/maps/place/Glenlo+Abbey+Hotel+%26+Estate/@53.3003241,-9.1007902,17z/data=!3m1!4b1!4m8!3m7!1s0x485b967079cce47d:0x151d760f108f8405!5m2!4m1!1i2!8m2!3d53.3003241!4d-9.0986015");
            Device.OpenUri(uri);
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hotel());
        }
    }
}