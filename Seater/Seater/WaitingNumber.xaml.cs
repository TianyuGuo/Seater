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
    public partial class WaitingNumber: ContentPage
        {
        public WaitingNumber()
        {
            InitializeComponent();
        }

        private void Get_Waiting_Number(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfirmationPage());
        }

    }
}
