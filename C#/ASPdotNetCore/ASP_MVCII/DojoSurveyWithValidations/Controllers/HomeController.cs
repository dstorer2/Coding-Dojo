﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    [Route("survey")]
    public IActionResult Survey(SurveyResult newSurvey)
    {
        if(ModelState.IsValid)
        {
            return View(newSurvey);
        }
        else
        {
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
