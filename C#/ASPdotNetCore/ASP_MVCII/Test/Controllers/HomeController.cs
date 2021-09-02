using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost("create/product")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("create/user")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpGet("success")]
        public string Success()
        {
            return "You have successfully submitted!";
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
