using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COVID19WebApp.Models
{
    public class Covid19Results
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_abbreviation")]
        public string CountryAbbreviation { get; set; }

        [JsonPropertyName("total_cases")]
        public string TotalCases { get; set; }

        [JsonPropertyName("new_cases")]
        public string NewCases { get; set; }

        [JsonPropertyName("total_deaths")]
        public string TotalDeaths { get; set; }

        [JsonPropertyName("new_deaths")]
        public string NewDeaths { get; set; }

        [JsonPropertyName("total_recovered")]
        public string TotalRecovered { get; set; }

        [JsonPropertyName("active_cases")]
        public string ActiveCases { get; set; }

        [JsonPropertyName("serious_critical")]
        public string SeriousCritical { get; set; }

        [JsonPropertyName("cases_per_mill_pop")]
        public string CasesPerMillionPopulation { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }
        
        
    }
}
