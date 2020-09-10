using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19WebApp.Models.Interfaces
{
    public interface ICovid19Data
    {
        Task<WorldDataObject> GetCovid19WorldData();
        Task<CountryDataObject> GetCovid19DataForCountry(string country);

    }
}
