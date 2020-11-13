using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Pages.Home   
{
    public class IndexModel : PageModel
    {
        //dependency injection
     
        private ICovid19Data _covid19;

        [BindProperty]
        public WorldDataObject worldData { get; set; }

        
        public List<CountryResults> countryData { get; set; }


        [BindProperty]
        public string Country { get; set; }


        public IndexModel(ICovid19Data covid19)
        {
            _covid19 = covid19;
        
        }

        public async Task OnGet()
        {
            
            var candy = await _covid19.GetCovid19WorldData();
            worldData = new WorldDataObject();

            worldData.Results = new WorldResults[1];
            worldData.Results[0] = new WorldResults();
            worldData.Results[0].Confirmed = candy.results[0].confirmed.ToString();
            worldData.Results[0].Deaths = candy.results[1].deaths.ToString();
            worldData.Results[0].Recovered = candy.results[2].recovered.ToString();

        }

    }
}
