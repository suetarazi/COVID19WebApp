using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class DataObject
    {
        [JsonPropertyName("data")]
        public RowsObject Data { get; set; }
    }
}
