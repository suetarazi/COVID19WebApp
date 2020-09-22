using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Pages.Results
{
    public class ResultsModel : PageModel
    {
        private ICovid19Data _covid19;
        private IEnumerator _enumerator;

        public ResultsModel(ICovid19Data covid19, IEnumerator enumerator)
        {
            _covid19 = covid19;
            _enumerator = enumerator;
        }

        public CountryDataObject countryData { get; set; }

        public List<CountryResults> CountryResults { get; set; }
        
        public void OnGet()
        {
        
        }
    }
}
