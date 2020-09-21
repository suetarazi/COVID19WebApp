using COVID19WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.ViewModels;

namespace COVID19WebApp.ViewModels
{
    public class WorldAndCountryViewModel
    {
        public WorldDataObject world { get; set; }

        public CountryDataObject countryDataObject { get; set; }

        public string Country { get; set; }

    }
        public class Result
        {
            public int confirmed { get; set; }
            public int? deaths { get; set; }
            public int? recovered { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public long last_updated { get; set; }
        }

        //public WorldResults[] Results { get; set; }

        //public string Last_Updated { get; set; }

}
