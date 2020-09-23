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
 //       private IEnumerator _enumerator;

        public ResultsModel(ICovid19Data covid19)
        {
            _covid19 = covid19;
            //_enumerator = enumerator;
        }

        public CountryDataObject countryData { get; set; }

        public List<CountryResults> CountryResults { get; set; }

        [BindProperty]
        public string Country { get; set; }

        public void OnGet()
        {
        
        }

        public async void OnPost()
        //public async Task<IActionResult> OnPostAsync()
        {
            countryData = new CountryDataObject();
            CountryResults = new List<CountryResults>();
            
            //TempData["country"] = country;
            //Country = Request.Form[nameof(Country)];
            //List<CountryResults> countryData = await _covid19.GetCovid19DataForCountry(Country);
            var apiData = await _covid19.GetCovid19DataForCountry(Country);
            //apiData.ToList<string>();
            countryData.CountryResults = apiData;
            

            //return RedirectToAction("/Results/Results", countryData);
            
            
        }
    }
}
