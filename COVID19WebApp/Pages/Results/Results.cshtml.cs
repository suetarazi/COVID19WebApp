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
 
        public ResultsModel(ICovid19Data covid19)
        {
            _covid19 = covid19;
  
        }

        public CountryDataObject countryData { get; set; }

        public List<CountryResults> CountryResults { get; set; }

        [BindProperty]
        public string Country { get; set; }

        public void OnGet()
        {
        
        }

        public async Task<IActionResult> OnPost()
        {
            countryData = new CountryDataObject();
            CountryResults = new List<CountryResults>();

            try 
            { 
            var apiData = await _covid19.GetCovid19DataForCountry(Country);
        
                countryData.CountryResults = apiData;

                return Page();
            }

            catch
            {
                //Note: This redirects to /Views/Home/Results.cs which is just a RazorView and NOT the RazorPage Results.cs
                return RedirectToAction("Results");
            }

            
            
        }
    }
}
