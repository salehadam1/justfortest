﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWProject_2019
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu_loam : ContentPage
	{
        // declare variable 
        // float to get the number of qunt that the user Enter
        float ID1;
        float ID2;
        float ID3;
        float ID4;
        float ID5;
        float ID6;
        // total price 
        float total;
        //String to hold the Menu data
        String plan1;
        String plan2;
        String plan3;
        String plan4;
        String plan5;
        String plan6;

        public Menu_loam ()
		{
			InitializeComponent ();
		}

        // button click holad the qunt and the topic that the user chose
        private void Add_Clicked(object sender, EventArgs e)
        {
            //float check if Enter box was empty or the user chose 0 or not
            float check = (float)Convert.ToDecimal(Qub1.Text);
            // if ckeck equal or less 0 then do not do any calculator and save float ID1 to 0
            if (check <= 0)
            {
                ID1 = 0;
            }
            // else do the calculator and save to float ID1 and get the Menu topic to the String plan1 
            // and so on for the next 5 add button just with defreent float and String name
            else
            {
                ID1 = check * 16;
                plan1 = "Connemara air-dried lamb  X " + check;
            }
        }

        private void Add2_Clicked(object sender, EventArgs e)
        {
            float check = (float)Convert.ToDecimal(Qub2.Text);
            if (check <= 0)
            {
                ID2 = 0;
            }
            else
            {
                ID2 = check * 16;
                plan2 = "Gubbeen moulded salami  X " + check;
            }

        }

        private void Add3_Clicked(object sender, EventArgs e)
        {
            float check = (float)Convert.ToDecimal(Qub3.Text);
            if (check <= 0)
            {
                ID3 = 0;
            }
            else
            {
                ID3 = check * 16;
                plan3 = "Gubbeen  coppa  X " + check;
            }
        }

        private void Add4_Clicked(object sender, EventArgs e)
        {
            float check = (float)Convert.ToDecimal(Qub4.Text);
            if (check <= 0)
            {
                ID4 = 0;
            }
            else
            {
                ID4 = check * 28;
                plan4 = "Edalo 2018 Bodegas Contreras Ruiz Zalema, Condado de Huelva, Spain  X " + check;
            }
        }

        private void Add5_Clicked(object sender, EventArgs e)
        {
            float check = (float)Convert.ToDecimal(Qub5.Text);
            if (check <= 0)
            {
                ID5 = 0;
            }
            else
            {
                ID5 = check * 29;
                plan5 = "Val de Loire ‘Lombeline’ 2018 Domaine Emile Balland  Sauvignon Blanc, Loire, France  X " + check;
            }
        }

        private void Add6_Clicked(object sender, EventArgs e)
        {
            float check = (float)Convert.ToDecimal(Qub7.Text);
            if (check <= 0)
            {
                ID6 = 0;
            }
            else
            {
                ID6 = check * 35;
                plan6 = "Blanco de Hornillos 2017 Callejuela Palomino Fino, San Lucar de Barrameda, Spain  X " + check;
            }
        }

        // back button to the Aniar page
        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loam_Rest());
        }

        //clear to refresh the Menu page
        private void Clear_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu_loam());
        }

        // check button to show out the DisplayAlert what the user chose
        private void Check_Clicked(object sender, EventArgs e)
        {
            total = ID1 + ID2 + ID3 + ID4 + ID5 + ID6;
            if (total > 0)
            {
                //  Answer.Text = "Total € " + total;
                DisplayAlert("You Chose\n", plan1 + "\n " + plan2 + "\n " + plan3 + "\n " + plan4 + "\n " + plan5 + "\n " + plan6 + "\n Totel =  €" + total, "ok");
            }
            else
            {
                // Answer.Text = " nell";
                DisplayAlert("Check", "pleas chose one of the menu", "ok");
            }

        }
    }
}