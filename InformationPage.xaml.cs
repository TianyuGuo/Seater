using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Seater.Views
{
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }
        private void Button_Clicked_search(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }

        private void Button_Clicked_reserve(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservationPage1());
        }

        private void Button_Clicked_profile(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
    }
}
