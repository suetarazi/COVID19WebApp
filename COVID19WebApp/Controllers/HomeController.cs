using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using COVID19WebApp.Models;
using COVID19WebApp.Models.Interfaces;


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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            WorldDataObject result = await _covid19.GetCovid19WorldData();
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> Results(string country)
        {
            List<CountryResults> results = await _covid19.GetCovid19DataForCountry(country);
            string test;       

            return View(results);
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //    //return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
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
