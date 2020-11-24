﻿using System;
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
        public IActionResult Index(string state)
        {

            return Redirect($"Representatives/state?state={state}");
            //return Content($"{state}");
        }

        public async Task<IActionResult> Ballot(string state)
        {
            return View(await _representativeService.ListStateRepresentativesAsync("OH"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult HelloWorld()
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
