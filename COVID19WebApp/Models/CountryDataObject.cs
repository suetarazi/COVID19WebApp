using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class CountryDataObject
    {
        [JsonProperty("results")]
        public List<CountryResults> CountryResults { get; set; }
    }
}
