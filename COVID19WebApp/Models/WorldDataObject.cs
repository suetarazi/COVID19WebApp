using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    //from API: https://2019ncov.asia/api/cdr
    public class WorldDataObject
    {

        [JsonPropertyName("results")]
        public WorldResults[] Results { get; set; }


        [JsonPropertyName("last_updated")]
        public string Last_Updated { get; set; }
    }
}
