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

        public Task<RowsObject> GetCovid19DataForCountry()
        {
            throw new NotImplementedException();
        }

        public async Task<RowsObject> GetCovid19WorldData()
        {
            var baseUrl = @"https://corona-virus-stats.herokuapp.com/api/v1/cases/countries-search";
            string route = "country";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            RowsObject rows = JsonConvert.DeserializeObject<RowsObject>(response);

            return rows;
        }
    }
}
