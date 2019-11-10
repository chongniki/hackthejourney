using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hackthejourney
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        async void OnFlightButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlightInfo());
        }
        async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReminderPage());
        }

    }
}
