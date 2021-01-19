using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CivicsApp.Models;

namespace CivicsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IRepresentativeService _representativeService;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _representativeService = new RepresentativeService();

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string address, string city, string state, string zipcode, string district)
        {
            return Redirect($"Representatives/YourDistrict?address={address}&city={city}&state={state}&zipcode={zipcode}&district={district}");
        }

        //public async Task<IActionResult> Ballot(string state)
        //{
        //    return View(await _representativeService.ListStateRepresentativesAsync("OH"));
        //}

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
