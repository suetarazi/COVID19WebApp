using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;
using COVID19WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Views.Home
{
    public class IndexModel : PageModel
    {
        //dependency injection
        private WorldDataObject _world;

        private CountryDataObject _countryDataObject;

        private ICovid19Data _covid19;

        [BindProperty]
        public WorldAndCountryViewModel AllData { get; set; }

        public void RegisterModel(WorldDataObject world, CountryDataObject countryDataObject, ICovid19Data covid19)
        {
            _world = world;
            _countryDataObject = countryDataObject;
            _covid19 = covid19;
        }

        public async Task<IActionResult> OnGet()
        {
            WorldDataObject result = await _covid19.GetCovid19WorldData();

            return Page();
        }
        

        //public void OnPost()
        //{

        //    List<CountryResults> results = await _covid19.GetCovid19DataForCountry(country);
        //    return RedirectToAction(Action, Controller, country);
        
        //}
    }
}
