﻿using COVID19WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19WebApp.Models.Interfaces
{
    public interface ICovid19Data
    {
        Task<Root> GetCovid19WorldData();
        Task<List<CountryResults>> GetCovid19DataForCountry(string country);

    }
}
