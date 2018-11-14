using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seater
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReservationPage1 : ContentPage
	{
		public ReservationPage1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

                Navigation.PushAsync(new ReservationPage2());
       
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

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }
    }
}