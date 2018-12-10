using System;

using Xamarin.Forms;

namespace Seater
{
    public class WaitingNumber : ContentPage
    {
        public WaitingNumber()
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

