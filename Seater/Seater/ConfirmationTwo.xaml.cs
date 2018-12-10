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

    public partial class ConfirmationPageTwo: ContentView
    {

        public ConfirmationPageTwo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //This should go to the reservation page
            Application.Current.MainPage = new Login(); 
        }
    }
}
