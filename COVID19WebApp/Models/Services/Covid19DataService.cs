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
        private string baseUrl = @"https://corona-virus-stats.herokuapp.com/api/v1/cases/countries-search?search=";

        /// <summary>
        /// Get specific covid-19 data for a given country
        /// </summary>
        ///<param name="country">the country entered</param>
        /// <returns></returns>
        public async Task<DataObject> GetCovid19DataForCountry(string country)
        {
            string route = "country";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");
            
            DataObject rows = JsonConvert.DeserializeObject<DataObject>(response);

            return rows;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public async Task<DataObject> GetCovid19WorldData()
        {
            string route = "world";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            DataObject rows = JsonConvert.DeserializeObject<DataObject>(response);

            return rows;
        }

    }
}
