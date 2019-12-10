using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SWProject_2019
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hotel());
        }

        private void Museum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Museum());
        }

        private void Restaurants_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Restaurants());
        }

        private void Nightlife_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nightlife());
        }
    }
}
