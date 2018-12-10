using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seater
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginMaster : ContentPage
    {
        public ListView ListView;

        public LoginMaster()
        {
            InitializeComponent();

            BindingContext = new LoginMasterViewModel();
            ListView = MenuItemsListView;
        }

        class LoginMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<LoginMenuItem> MenuItems { get; set; }

            public LoginMasterViewModel()
            {
                MenuItems = new ObservableCollection<LoginMenuItem>(new[]
                {
                    new LoginMenuItem { Id = 0, Title = "Search", TargetType = typeof(SearchPage) },
                    new LoginMenuItem { Id = 0, Title = "Reservation", TargetType = typeof(ReservationPage1) },
                    new LoginMenuItem { Id = 0, Title = "Profile", TargetType = typeof(ProfilePage) },
                    new LoginMenuItem { Id = 0, Title = "Logout", TargetType = typeof(LoginDetail) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}