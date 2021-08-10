using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio1.Models;

namespace Portfolio1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
    
    [HttpGet]
    [Route("projects")]
    public ViewResult Projects()
    {
        return View();
    }
    [HttpGet]
    [Route("contact")]
    public ViewResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
