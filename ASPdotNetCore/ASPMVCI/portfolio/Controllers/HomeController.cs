using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public string Index()
    {
        return "This is my Index";
    }

    [HttpGet("projects")]
    public string Projects()
    {
        return "This is my Projects";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my contacts";
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
