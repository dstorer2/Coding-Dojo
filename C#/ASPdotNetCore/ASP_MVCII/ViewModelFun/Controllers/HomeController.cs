using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("")]
    public IActionResult Message()
    {
        string message = "Lorem";

        return View("Message", message);
    }

    [HttpGet]
    [Route("/numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = new int[]
        {
            1,
            2,
            3,
            10,
            43,
            5
        };
        return View(numbers);
    }
    [HttpGet]
    [Route("/users")]
    public IActionResult Users()
    {
        List<string> users = new List<string>
        {
            "Moose Phillips",
            "Sarah",
            "Jerry",
            "Rene Ricky",
            "Barbarah"
        };
        return View(users);
    }
    [HttpGet]
    [Route("/user")]
    public IActionResult User()
    {
        User moose = new User()
        {
            FirstName = "Moose",
            LastName = "Phillips"
        };
        return View(moose);
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
