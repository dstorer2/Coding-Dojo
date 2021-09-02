using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.ToList();
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid){
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                return View("add");
            }
        }

        [HttpGet("dish/{dishId}")]
        public IActionResult DisplayDish(int dishId)
        {
            Dish RetreivedDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(RetreivedDish);
        }
        [HttpGet("dish/{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish RetreivedDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(RetreivedDish);
        }
        [HttpGet("dish/{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish deleteMe = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            _context.Dishes.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpPost("dish/SubmitEdit")]
        public IActionResult SubmitEdit(Dish updateDish)
        {
            Dish RetreivedDish = _context.Dishes.FirstOrDefault(dish => dish.DishId == updateDish.DishId);
            RetreivedDish.Name = updateDish.Name;
            RetreivedDish.Chef = updateDish.Chef;
            RetreivedDish.Calories = updateDish.Calories;
            RetreivedDish.Tastiness = updateDish.Tastiness;
            RetreivedDish.Description = updateDish.Description;
            RetreivedDish.UpdatedAt = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index");


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
