using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs
                .Include(chef => chef.CreatedDishes)
                .ToList();
            return View();
        }
        [HttpGet("chef/add")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpPost("chef/submit")]
        public IActionResult SubmitChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes
                .Include(dish => dish.Creator)
                .ToList();

            return View();
        }

        [HttpGet("dishes/add")]
        public IActionResult AddDish()
        {
            ViewBag.AllChefs = _context.Chefs
                .Include(chef => chef.CreatedDishes)
                .ToList();
            return View();
        }

        [HttpPost("dishes/submit")]
        public IActionResult SubmitDish(Dish newDish)
        {
            if(ModelState.IsValid){
                _context.Add(newDish);
                _context.SaveChanges();

                return RedirectToAction("Dishes");
            }

            return View("AddDish");
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
