using RestFul.models;
using RestFul.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RestFul.ViewModels
{
    public class PlaceViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        IPlaceService placeService = DependencyService.Get<IPlaceService>();

        private ObservableCollection<Venue> _venues;
        public ObservableCollection<Venue> Venues
        {
            get
            {
                return _venues;
            }
            set
            {
                _venues = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Venues"));
            }
        }
        public PlaceViewModel()
        {
            GetPlace();
        }
         public string Base_Url = "https://api.foursquare.com/v2/venues/search";
        public string ClientId = "VS1YYE11JSFLDT3VWFKWWHMUZ03MVXPE5RTQ0HIJWPC4UETN";
        public string ClientSecret = "3H35ZFUMVKSO4I3GEMCJECQT0CEGZTGBQXW4EILZOBVLJQRZ";
        public int Radius = 50;
        public int limit = 10;
        public string Version = "20200424";
        public async void GetPlace()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            if (location != null)
            {

                var result = placeService.GetPlace(Base_Url, location.Latitude, location.Longitude, Radius, limit, Version, ClientId, ClientSecret);
                if (result != null)
                {
                    Venues = result.Response.Venues;
                }
            }
        }
    }
}
