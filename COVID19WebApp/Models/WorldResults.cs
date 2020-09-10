using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class WorldResults
    {
        [JsonPropertyName("confirmed")]
        public string Confirmed { get; set; }

        [JsonPropertyName("deaths")]
        public string Deaths { get; set; }

        [JsonPropertyName("recovered")]
        public string Recovered { get; set; }
    }
}
