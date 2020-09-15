using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class CountryResults
    {
        [JsonProperty("country_region")]
        public string CountryRegion { get; set; }

        [JsonProperty("confirmed")]
        public string Confirmed { get; set; }

        [JsonProperty("deaths")]
        public string Deaths { get; set; }

        [JsonProperty("recovered")]
        public string Recovered { get; set; }

        [JsonProperty("last_updated")]
        public string Last_Updated { get; set; }
    }
}
