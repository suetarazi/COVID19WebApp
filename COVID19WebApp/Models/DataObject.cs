using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class DataObject
    {
        [JsonPropertyName("paginationMeta")]
        public Object Pagination { get; set; }

        [JsonPropertyName("last_update")]
        public Object LastUpdated { get; set; }

        [JsonPropertyName("rows")]
        public Covid19Results[] Rows { get; set; }
    }
}
