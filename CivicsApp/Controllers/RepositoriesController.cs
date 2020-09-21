using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using CivicsApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CivicsApp.Controllers
{
    public class RepositoriesController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public IActionResult Repositories()
        {
            return View();
        }

        // TODO
        // Convert the following method into the controller:
        // private static async Task<List<Repository>> ProcessRepositories()
        //{
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        //    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        //    var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
        //    var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);
        //    return repositories;
        //}


    }
}
