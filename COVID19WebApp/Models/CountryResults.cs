using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class CountryResults
    {
        [JsonPropertyName("country_region")]
        public string CountryRegion { get; set; }

        [JsonPropertyName("confirmed")]
        public string Confirmed { get; set; }

        [JsonPropertyName("deaths")]
        public string Deaths { get; set; }

        [JsonPropertyName("recovered")]
        public string Recovered { get; set; }

        [JsonPropertyName("last_updated")]
        public string Last_Updated { get; set; }
    }
}
