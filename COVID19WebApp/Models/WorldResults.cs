using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{

    //from API: https://2019ncov.asia/api/cdr
    //this class represents the array objects inside WorldDataObject.cs

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
