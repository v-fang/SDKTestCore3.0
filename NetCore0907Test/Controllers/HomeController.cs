using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore0907Test.Models;

namespace NetCore0907Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Get();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IEnumerable<string> Get()
        {
            HttpClient client = new HttpClient();
            var res1 = client.GetStringAsync("https://bing.com").Result;
            var res2 = client.GetStringAsync("https://net0907test.azurewebsites.net/").Result;
            return new string[] { "value1", "value2" };
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
