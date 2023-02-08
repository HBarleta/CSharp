using System.Diagnostics;
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

    [HttpGet("/results")]

    public IActionResult Results()
    {
        return View();
    }

    [HttpPost("/addUser")]

    public IActionResult addUser(string Name, string DojoLocation, string FavoriteLanguage, string Comments)
    {
        List<string> Results = new List<string>() { Name, DojoLocation, FavoriteLanguage, Comments };
        ViewBag.SurveyResults = Results;
        ViewBag.Message = "Here are your results!";
        Console.WriteLine($"Name: {Name} Location: {DojoLocation} Favorite Language: {FavoriteLanguage} Comments: {Comments}");
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
