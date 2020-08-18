using COVID19WebApp.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models.Services
{
    public class Covid19DataService : ICovid19Data
    {
        private static readonly HttpClient client = new HttpClient();

        public Task<DataObject> GetCovid19DataForCountry()
        {
            throw new NotImplementedException();
        }

        public async Task<DataObject> GetCovid19WorldData(string country)
        {
            var baseUrl = @"https://corona-virus-stats.herokuapp.com/api/v1/cases/countries-search?search=";
            string route = "world";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            DataObject rows = JsonConvert.DeserializeObject<DataObject>(response);

            return rows;
        }

        public Task<DataObject> GetCovid19WorldData()
        {
            throw new NotImplementedException();
        }
    }
}
