using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Petstagram.Models;

namespace Petstagram.Controllers;

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


    [HttpPost("/addPet")]
    public IActionResult AddPet(string PetType, string PetName, int Age, string HairColor)
    {
        if (PetType == "dolphin")
        {
            ViewBag.SecretMessage = "You've entered a secret pet! ";
            return View("Index");
        }

        Console.WriteLine($"Name: {PetName} Age: {Age} Hair Color: {HairColor}");
        // return RedirectToAction("Index");
        return Redirect("/");
    }

    // [HttpGet("{**path}")]
    // public RedirectToActionResult Unknown()
    // {
    //     Console.WriteLine("Page not found");
    //     return RedirectToAction("Index");
    // }

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
