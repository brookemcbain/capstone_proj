using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Capstone.Models;
using Newtonsoft.Json.Linq;

namespace Capstone.Services
{
    public class GeocodingService
    {
        public async Task<Location> AttachLatAndLong(Location location)
        {
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={location.Address}+{location.City}+{location.State}+&key={APIKeys.GOOGLE_API_KEY}";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonResult = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(jsonResult);
            location.Latitude = (double)jObject["results"][0]["geometry"]["location"]["lat"];
            location.Longitude = (double)jObject["results"][0]["geometry"]["location"]["lng"];

            return location;
        }
    }
}
