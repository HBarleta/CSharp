using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionsLec.Models;

namespace SessionsLec.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost("/guests/new")]
    public IActionResult ProcessName(Guest guest)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        else
        {
            HttpContext.Session.SetString("guestName", guest.GuestName);
            return RedirectToAction("Dashboard");
        }
    }

    [HttpGet("/guests/home")]
    public ViewResult Dashboard()
    {
        string? guestName = HttpContext.Session.GetString("guestName");
        return View("Dashboard", guestName);
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
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
