using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Views.Home
{
    public class IndexModel : PageModel
    {
        //dependency injection

        public WorldAndCountryViewModel AllData { get; set; }

        public void OnGet()
        {
            WorldDataObject result = await _covid19.GetCovid19WorldData();

        }
        

        public void OnPost()
        {

            List<CountryResults> results = await _covid19.GetCovid19DataForCountry(country);
            return RedirectToAction(Action, Controller, country);
        
        }
    }
}
