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

        public List<CountryResults> countryData { get; set; }

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
            worldData = await _covid19.GetCovid19WorldData();

            
        }


        //public async List<CountryResults> OnPost(string country)
        //{

        //    List<CountryResults> countryData = await _covid19.GetCovid19DataForCountry(country);
        //    return RedirectToAction(Action, Controller, country);
        //    return RedirectToAction("/Home/Results", countryData);
        //}
    }
}
