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

        private void schedule_cancel_Button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservationPage2());

        }

        private void reschedule_Button(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }
    }
}