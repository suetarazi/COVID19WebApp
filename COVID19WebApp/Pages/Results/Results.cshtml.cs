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

        public async Task<IActionResult> OnPost()
        //public async Task<IActionResult> OnPostAsync()
        {
            countryData = new CountryDataObject();
            CountryResults = new List<CountryResults>();

            var apiData = await _covid19.GetCovid19DataForCountry(Country);
        
            if (apiData != null)
            {

                countryData.CountryResults = apiData;

                return Page();
            }

            else
            {
                //Note: This redirects to /Views/Home/Results.cs which is just a RazorView and NOT the RazorPage Results.cs
                return RedirectToAction("Results");
            }

            
            
        }
    }
}
