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
using System.ComponentModel.Design;

namespace COVID19WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISortingHat _sortingHat;

        public HomeController(ILogger<HomeController> logger, ISortingHat sortingHat)
        {
            _logger = logger;
            _sortingHat = sortingHat;
        }

        public SortingHat HouseName { get; set; }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            HouseName = await _sortingHat.SortingHatOutcome();
            return View(HouseName);
        }

        public IActionResult Results()
        {
            return View();
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
       

