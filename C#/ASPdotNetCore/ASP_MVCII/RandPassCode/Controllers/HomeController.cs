using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandPassCode.Models;
using Microsoft.AspNetCore.Http;

namespace RandPassCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string libra = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Random rand = new Random();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("generate")]
        public IActionResult Generate()
        {
            int count = 0;

            if (HttpContext.Session.GetInt32("Count") != null){
                count = (int)HttpContext.Session.GetInt32("Count");
            }
            
            string randomPass = "";
            for(var i = 0; i < 14; ++i){
                var ran = rand.Next(libra.Length);
                randomPass += libra[ran];
            }
            HttpContext.Session.SetString("PassCode", randomPass);
            HttpContext.Session.SetInt32("Count", count + 1);
            
            ViewBag.PassCode = HttpContext.Session.GetString("PassCode");
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            return View("Index");
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null){
                HttpContext.Session.SetInt32("Count", 0);
                ViewBag.Count = HttpContext.Session.GetInt32("Count");
            }
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
