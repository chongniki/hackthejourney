using System;

using Xamarin.Forms;

namespace hackthejourney
{
    public class FlightInfo : ContentPage
    {
        public FlightInfo()
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

