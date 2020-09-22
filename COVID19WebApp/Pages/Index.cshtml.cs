using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.Controllers;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;
using COVID19WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Pages.Home   
{
    public class IndexModel : PageModel
    {
        //dependency injection
        //private WorldDataObject _world;

        //private CountryDataObject _countryDataObject;

        //private CountryResults _countryResults;

        private ICovid19Data _covid19;

        [BindProperty]
        //public WorldAndCountryViewModel AllData { get; set; }
        public WorldDataObject worldData { get; set; }

        //[BindProperty]
        public List<CountryResults> countryData { get; set; }

        [BindProperty]
        public string Country { get; set; }

        //WorldDataObject world, CountryDataObject countryDataObject, CountryResults _countryResults,
        public IndexModel(ICovid19Data covid19)
        {
        //    _world = world;
          //  _countryDataObject = countryDataObject;
            _covid19 = covid19;
         //   _countryResults = countryResults;
        }

        public async Task OnGet()
        {
            //WorldDataObject result = await _covid19.GetCovid19WorldData();
            //worldData = await _covid19.GetCovid19WorldData();
            var candy = await _covid19.GetCovid19WorldData();
            worldData = new WorldDataObject();

            worldData.Results = new WorldResults[1];
            worldData.Results[0] = new WorldResults();
            worldData.Results[0].Confirmed = candy.results[0].confirmed.ToString();
            worldData.Results[0].Deaths = candy.results[1].deaths.ToString();
            worldData.Results[0].Recovered = candy.results[2].recovered.ToString();

        }


        public async Task<IActionResult> OnPost(string country)
        {
            if (!ModelState.IsValid)
            {
                List<CountryResults> countryData = await _covid19.GetCovid19DataForCountry(country);
                return RedirectToAction("/Results/Results", countryData);
            }
            else
            {
                return Page();
            }
        }
    }
}
