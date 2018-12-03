
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
    public partial class CalendarPage : ContentPage
    {
            public CalendarPage()
            {
                InitializeComponent();
            }

            void OnDateSelected(object sender, DateChangedEventArgs args)
            {
                Recalculate();
            }

            void OnSwitchToggled(object sender, ToggledEventArgs args)
            {
                Recalculate();
            }

            void Recalculate()
            {
            var timeSpan =  startDatePicker.Date ;

                resultLabel.Text = String.Format("{0} day{1} between dates",
                                                 timeSpan.Day, timeSpan.Day == 1 ? "" : "s");
            }
        }

    }
