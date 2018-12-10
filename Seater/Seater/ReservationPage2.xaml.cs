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
	public partial class ReservationPage2 : ContentPage
	{
		public ReservationPage2 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }

    }
}