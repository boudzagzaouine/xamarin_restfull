using Newtonsoft.Json;
using RestFul.models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestFul.services
{
    public class PlaceServiceImpl : IPlaceService
    {
        public async Task<Place> GetPlace(string Base_url, double lat, double lon, int radius, int limit, string version, string clientId, string clientSecret)
        {
            string ll = $"{lat},{lon}";
            string Url = Base_url + $"?ll={ll}$radius={radius}$limit={limit}$v={version}$client_id={clientId}$client_secret={clientSecret}";
            HttpClient _client= new HttpClient();
            HttpResponseMessage responseMessage = await _client.GetAsync(Url);

            if (responseMessage != null)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Place>(jsonString);
                return result;
            }
            return null;
        }
    }
}
