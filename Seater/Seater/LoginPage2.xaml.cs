﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seater
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage2 : ContentPage
	{
		public LoginPage2 ()
		{
			InitializeComponent ();
		}
        private void go_search_page(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage( new SearchPage()));
        }

        private void go_help(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void go_signup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
        private void go_facebook(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.facebook.com"));
        }
        private void go_google(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.google.com"));
        }
    }
}