using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Seater
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail= new NavigationPage(new SearchPage());
            IsPresented = false;
        }

        private void menu_search_button(object sender, EventArgs e)
        {
             Detail= new NavigationPage(new SearchPage());
            IsPresented = false;
        }
        private void menu_reserve_button(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ReservationPage1());
            IsPresented = false;
        }
        private void menu_profile_button(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProfilePage());
            IsPresented = false;
        }

    }
}
