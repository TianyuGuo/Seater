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
	public partial class OptionPage : ContentPage
	{
		public OptionPage ()
		{
			InitializeComponent ();
		}

        private void now_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalendarPage());
        }

        private void future_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}