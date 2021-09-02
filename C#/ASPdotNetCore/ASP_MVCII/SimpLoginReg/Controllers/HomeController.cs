using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpLoginReg.Models;

namespace SimpLoginReg.Controllers
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

        [HttpPost("create/register")]
        public IActionResult CreateRegister(IndexViewModel modelData)
        {
            Register subbmittedRegister = modelData.NewRegistration;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("create/login")]
        public IActionResult CreateLogin(IndexViewModel modelData)
        {
            Login submittedLogin = modelData.NewLogin;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        
        [HttpGet("success")]
        public string Success()
        {
            return "Success!";
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
