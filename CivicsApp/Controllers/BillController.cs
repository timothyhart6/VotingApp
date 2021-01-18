using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CivicsApp.Models.Bills.ServiceLayer;
using Microsoft.AspNetCore.Mvc;


namespace CivicsApp.Controllers
{
    public class BillController : Controller
    {
        private BillService billService;

        public BillController()
        {
            billService = new BillService();
        }

        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync(string billSlug)
        {
            return View(await billService.FetchBillDetailsAsync(billSlug));
        }


    }
}
