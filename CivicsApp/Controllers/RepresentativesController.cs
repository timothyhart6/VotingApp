using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CivicsApp.Data;
using CivicsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CivicsApp.Controllers
{
    public class RepresentativesController : Controller
    { 
        private readonly RepresentativeContext _context;

        public RepresentativesController(RepresentativeContext context)
        {
            _context = context;
        }

        // GET: /Representatives>/
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";

            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            Representative myDeserializedClass = JsonConvert.DeserializeObject<Representative>(stringResult);

            return View(myDeserializedClass);
        }

        //id = 1;
        //var representative = await _context.Representative
        //    .FirstOrDefaultAsync(m => m.Id == id);
        //if (representative == null)
        //{
        //    return NotFound();
        //}




        //// GET: Representative/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var representative = await _context.Representative
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (representative == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(representative);
        //}
    }
}
