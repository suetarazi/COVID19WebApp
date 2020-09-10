using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class CountryDataObject
    {
        [JsonPropertyName("results")]
        public CountryResults[] CountryResults { get; set; }
    }
}
