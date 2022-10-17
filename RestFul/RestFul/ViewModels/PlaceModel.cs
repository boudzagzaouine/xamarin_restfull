using RestFul.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RestFul.ViewModels
{
    public class PlaceModel
    {
        public Command CmGotoPlacePlage { get; set; }

        public PlaceModel()
        {
            CmGotoPlacePlage = new Command(GotoPlacePlage);
        }

        private void GotoPlacePlage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PlacePage());
        }
    }
}
