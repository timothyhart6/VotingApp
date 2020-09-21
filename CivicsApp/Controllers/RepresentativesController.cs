﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CivicsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CivicsApp.Controllers
{
    public class RepresentativesController : Controller
    { 
        private readonly RepresentativeContext _context;

        private static readonly HttpClient client = new HttpClient();


        public RepresentativesController(RepresentativeContext context)
        {
            _context = context;
        }

        //// GET: /Representatives>/
        //public async Task<IActionResult> IndexAsync()
        //{
        //    return View(await _context.Representative.ToListAsync());
        //}

        // GET: /Representatives>/
        public async Task<IActionResult> Index(int id)
        {
            id = 1;
            var representative = await _context.Representative
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representative == null)
            {
                return NotFound();
            }

            return View(representative);
        }

        // GET: Representative/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var representative = await _context.Representative
                .FirstOrDefaultAsync(m => m.Id == id);
            if (representative == null)
            {
                return NotFound();
            }

            return View(representative);
        }
    }
}
