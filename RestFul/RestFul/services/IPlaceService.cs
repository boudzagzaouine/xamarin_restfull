using RestFul.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestFul.services
{
    public interface IPlaceService
    {
        Task<Place> GetPlace(string Base_url,double lat,double lon,int radius,int limit,string version,string clientId,string clientSecret);

    }
}
