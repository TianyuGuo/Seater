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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();
		}
        private void profile_search_button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void profile_logout_button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage2());
        }
    }
}