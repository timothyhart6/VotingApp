using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CivicsApp.Models;
using Microsoft.AspNetCore.Mvc;
using CivicsApp.Data;


namespace CivicsApp.Controllers
{
    public class SenatorsController : Controller
    { 
        private ISenatorService _senatorService;

        public SenatorsController()
        {
            _senatorService = new SenatorService();
        }
    
        // GET: /Senators/
        public async Task<IActionResult> Index()
        {
            return View(await _senatorService.ListSenatorsAsync());
        }
    }
}
