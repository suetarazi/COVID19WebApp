using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class RowsObject
    {
        [JsonPropertyName("rows")]
        public Covid19Results Rows { get; set; }
    }
}
