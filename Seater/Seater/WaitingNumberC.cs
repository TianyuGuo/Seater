using System;

using Xamarin.Forms;

namespace Seater
{
    public class WaitingNumberC : ContentPage
    {
        public WaitingNumberC()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

