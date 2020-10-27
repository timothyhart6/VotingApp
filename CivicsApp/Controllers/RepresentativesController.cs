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
        private IRepresentativeService _representativeService;
        

        public RepresentativesController(RepresentativeContext context)
        {
            _context = context;
            _representativeService = new RepresentativeService();
        }


        // GET: /Representatives>/
        public async Task<IActionResult> Index()
        {
            return View(await _representativeService.ListRepresentativesAsync());
        }

        /* USED FOR DATABASE RETRIEVAL
        id = 1;
        var representative = await _context.Representative
            .FirstOrDefaultAsync(m => m.Id == id);
        if (representative == null)
        {
            return NotFound();
        }
        */

        //GET: Representative/State/OH
        //public async Task<IActionResult> State(String state)
        //{
        //    return View(await _representativeService.ListStateRepresentativesAsync(state));
        //}
    }
}
