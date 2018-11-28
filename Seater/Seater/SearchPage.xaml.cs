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
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Tap_search(object sender, EventArgs e)
        {

        }
        private void Tap_picture1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OptionPage());
        }
    }
}