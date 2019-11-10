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
            calendarButton.Clicked += CalendarButton_Clicked;
            homeButton.Clicked += HomeButton_Clicked;
            guideButton.Clicked += GuideButton_Clicked;
            flightButton.Clicked += FlightButton_Clicked;
        }

        private void FlightButton_Clicked(object sender, EventArgs e)
        {
            // FlightInfo f = new FlightInfo();
            // f.IsVisible = true;
            App.Current.MainPage = new FlightInfo(); 

        }

        private void GuideButton_Clicked(object sender, EventArgs e)
        {
            // await App.Current.MainPage
        }

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void CalendarButton_Clicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }
    }
}
