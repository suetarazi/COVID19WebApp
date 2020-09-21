using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;
using COVID19WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COVID19WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICovid19Data _covid19;

        public HomeController(ILogger<HomeController> logger, ICovid19Data covid19)
        {
            _logger = logger;
            _covid19 = covid19;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    WorldDataObject result = await _covid19.GetCovid19WorldData();
        //    //WorldAndCountryViewModel worldAndCountryViewModel = new WorldAndCountryViewModel();


        //    return View(result);
        //}


        [HttpPost]
        public ActionResult Results(string country)
        {
            //List<CountryResults> results = await _covid19.GetCovid19DataForCountry(country);
            //string test;

            //WorldAndCountryViewModel worldAndCountryViewModel = new WorldAndCountryViewModel();
            //{

                //    world = WorldDataObject,
                //    CountryDataObject = CountryResults,
                //    Country = CountryResults.CountryResults.CountryRegion,
                //};

                return View(country);
            //    //return View(worldAndCountryViewModel(results));

            //    //    return RedirectToAction(nameof(Index));
            //    //    //return RedirectToAction(nameof(Index));
            //    //}
            //    //catch
            //    //{
            //    //    return View();
            //    //}

            }



            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        

    }
}
       

