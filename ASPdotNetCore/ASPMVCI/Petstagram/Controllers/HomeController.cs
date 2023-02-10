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

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost("/addPet")]
    public IActionResult AddPet(Pet newPet)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }


        if (newPet.PetType == "dolphin")
        {
            ViewBag.SecretMessage = "You've entered a secret pet! ";
            return View("Index");
        }
        Console.WriteLine($"Name: {newPet.Name} Age: {newPet.Age} Hair Color: {newPet.HairColor}");
        // return RedirectToAction("Index");
        return View("ViewPet", newPet);
    }

    [HttpGet("/viewPet")]
    public IActionResult ViewPet()
    {
        // ViewBag.Name = "Meesha";
        // ViewBag.Type = "Dog";
        // ViewBag.Age = 2;
        // ViewBag.HairColor = "Brown and White";
        Pet calebsPet = new Pet()
        {
            Name = "Meesha",
            PetType = "Dog",
            Age = 2,
            HairColor = "Brown and White",
        };
        return View("ViewPet", calebsPet);
    }



    [HttpGet("{**path}")]
    public RedirectToActionResult Unknown()
    {
        Console.WriteLine("Page not found");
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
