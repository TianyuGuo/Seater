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
    public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }

        public void ClickTap1(object sender, EventArgs e)
        {
            var page = new SearchPage();
            MainViewContent.Content = page.Content;
            MainViewContent.ControlTemplate = page.ControlTemplate;


        }

        public void ClickTap2(object sender, EventArgs e)
        {
            var page = new ReservationPage1();
            MainViewContent.Content = page.Content;

        }

        public void ClickTap3(object sender, EventArgs e)
        {
            var page = new ProfilePage();
            MainViewContent.Content = page.Content;

        }
	}
}