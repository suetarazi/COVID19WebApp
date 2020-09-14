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
        private string baseUrl = @"https://2019ncov.asia/api";
        

        //private string baseUrl = @"https://corona-virus-stats.herokuapp.com/api/v1/cases/countries-search?search=";

        /// <summary>
        /// Get specific covid-19 data for a given country
        /// </summary>
        ///<param name="country">the country entered</param>
        /// <returns></returns>
        public async Task<List<CountryResults>> GetCovid19DataForCountry(string country)
        {
            string route = "country_region";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            
            CountryDataObject allResults = JsonConvert.DeserializeObject<CountryDataObject>(response);

            //CountryDataObject queryObject = countryResults.Where(x => x.country_region == country);

            var queryObject = allResults.CountryResults.Where(c => c.CountryRegion == country); 

            //var queryObject = from c in allResults.CountryResults
            //                  where country == c.CountryRegion
            //                  select c;
            //{ c.country_region, country.confirmed, country.deaths, country.recovered, country.last_updated };


            return queryObject.ToList();

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public async Task<WorldDataObject> GetCovid19WorldData()
        {
            string route = "cdr";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{baseUrl}/{route}");

            WorldDataObject results = JsonConvert.DeserializeObject<WorldDataObject>(response);

            return results;
        }

    }
}
