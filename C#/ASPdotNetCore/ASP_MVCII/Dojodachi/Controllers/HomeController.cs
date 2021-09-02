using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Random rand = new Random();

        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("happiness", 20);
            HttpContext.Session.SetInt32("fullness", 20);
            HttpContext.Session.SetInt32("energy", 50);
            HttpContext.Session.SetInt32("meals", 3);
            HttpContext.Session.SetString("url", "~/img/happy_cat.png");
            HttpContext.Session.SetString("prompt", "Choose something for your Dojodachi to do!");
            HttpContext.Session.SetInt32("win", 0);
            HttpContext.Session.SetInt32("like", 1);


            return View();
        }

        [HttpGet("game")]
        public IActionResult Game()
        {
            if(HttpContext.Session.GetInt32("happiness") >= 100 && HttpContext.Session.GetInt32("fullness") >= 100 && HttpContext.Session.GetInt32("energy") >= 100){
                HttpContext.Session.SetString("prompt", "Congrats! You won!");
                HttpContext.Session.SetInt32("win", 1);
            }
            if(HttpContext.Session.GetInt32("happiness") <= 0 || HttpContext.Session.GetInt32("fullness") <= 0){
                HttpContext.Session.SetString("prompt", "You killed your Dojodachi... you monster.");
                HttpContext.Session.SetInt32("win", 2);
            }

            ViewBag.happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.energy = HttpContext.Session.GetInt32("energy");
            ViewBag.meals = HttpContext.Session.GetInt32("meals");
            ViewBag.url = HttpContext.Session.GetString("url");
            ViewBag.prompt = HttpContext.Session.GetString("prompt");
            ViewBag.win = HttpContext.Session.GetInt32("win");
            ViewBag.like = HttpContext.Session.GetInt32("like");

            return PartialView();
        }
        [HttpGet("play")]
        public IActionResult Play()
        {
            int energy = 0;
            if(HttpContext.Session.GetInt32("energy") != null){
                energy = (int)HttpContext.Session.GetInt32("energy");
            }

            if(energy  < 5){
                HttpContext.Session.SetString("prompt", "You do not energy to play. Try getting some sleep!");
                return RedirectToAction("game");
            }

            int like = rand.Next(0, 4);
            if(like > 0){
                int happiness = 0;
                if(HttpContext.Session.GetInt32("happiness") != null){
                    happiness = (int)HttpContext.Session.GetInt32("happiness");
                }
                int moreHappy = rand.Next(5, 11);

                HttpContext.Session.SetInt32("energy", energy - 5);
                HttpContext.Session.SetInt32("happiness", happiness + moreHappy);
                HttpContext.Session.SetInt32("like", 1);
                HttpContext.Session.SetString("prompt", $"Your played with your Dojodachi. Happiness +{moreHappy} Energy -5");
            }
            else{
                HttpContext.Session.SetInt32("energy", energy - 5);
                HttpContext.Session.SetInt32("like", 0);
                HttpContext.Session.SetString("prompt", $"Your played with your Dojodachi but it didn't like it. No change in happiness. Energy -5");
            }
            return RedirectToAction("game");
        }
        [HttpGet("feed")]
        public IActionResult Feed()
        {
            int like = rand.Next(0, 4);
            int meals = 0;
            if(HttpContext.Session.GetInt32("meals") != null){
                meals = (int)HttpContext.Session.GetInt32("meals");
            }
            if(meals == 0){
                HttpContext.Session.SetInt32("like", 0);
                HttpContext.Session.SetString("prompt", "You do not have any meals to feed to your Dojodachi. Trying getting off your ass and working a bit so you can put some godamn food on the godamn table");
                return RedirectToAction("game");
            }
            int fullness = 0;
            if(like > 0){
                if(HttpContext.Session.GetInt32("fullness") != null){
                    fullness = (int)HttpContext.Session.GetInt32("fullness");
                }
                int moreFull = rand.Next(5, 11);
                HttpContext.Session.SetInt32("meals", meals - 1);
                HttpContext.Session.SetInt32("fullness", fullness + moreFull);
                HttpContext.Session.SetInt32("like", 1);
                HttpContext.Session.SetString("prompt", $"Your fed your Dojodachi. Fullness +{moreFull} Meals -1");
            }
            else{
                HttpContext.Session.SetInt32("meals", meals - 1);
                HttpContext.Session.SetInt32("like", 0);
                HttpContext.Session.SetString("prompt", $"Your fed your Dojodachi but it didn't like it. No change to fullness. Meals -1");
            }
            return RedirectToAction("game");
        }
        [HttpGet("work")]
        public IActionResult Work()
        {
            int energy = 0;
            if(HttpContext.Session.GetInt32("energy") != null){
                energy = (int)HttpContext.Session.GetInt32("energy");
            }
            if(energy < 5){
                HttpContext.Session.SetString("prompt", "You do not have enough energy to work. Try getting some sleep.");
                return RedirectToAction("game");
            }
            int meals = 0;
            if(HttpContext.Session.GetInt32("meals") != null){
                meals = (int)HttpContext.Session.GetInt32("meals");
            }
            int moreMeals = rand.Next(1, 3);
            HttpContext.Session.SetInt32("energy", energy - 5);
            HttpContext.Session.SetInt32("meals", meals + moreMeals);
            HttpContext.Session.SetInt32("like", 1);
            HttpContext.Session.SetString("prompt", $"You and your Dojodachi got to work. Meals +{moreMeals} Energy -5");
            return RedirectToAction("game");
        }
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int energy = 0;
            if (HttpContext.Session.GetInt32("energy") != null){
                energy = (int)HttpContext.Session.GetInt32("energy");
            }
            int happiness = 0;
            if(HttpContext.Session.GetInt32("happiness") != null){
                happiness = (int)HttpContext.Session.GetInt32("happiness");
            }
            int fullness = 0;
            if(HttpContext.Session.GetInt32("fullness") != null){
                fullness = (int)HttpContext.Session.GetInt32("fullness");
            }
            HttpContext.Session.SetInt32("energy", energy + 15);
            HttpContext.Session.SetInt32("happiness", happiness - 5);
            HttpContext.Session.SetInt32("fullness", fullness - 5);
            HttpContext.Session.SetInt32("like", 1);
            HttpContext.Session.SetString("prompt", "Your Dojodachi got some sleep. Energy +15 Happiness -5 Fullness -5");
            return RedirectToAction("game");

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
