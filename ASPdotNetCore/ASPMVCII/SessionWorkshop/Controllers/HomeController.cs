using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

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

    [HttpPost("/user/new")]
    public IActionResult ProcessUser(User user)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }

        HttpContext.Session.SetString("userName", user.UserName);

        return RedirectToAction("Dashboard", user);
    }

    [HttpGet("/Dashboard/addOne")]
    public IActionResult AddOne()
    {
        int? sessNum = HttpContext.Session.GetInt32("num");
        int newNum = (int)sessNum + 1;
        HttpContext.Session.SetInt32("num", newNum);
        int? num = HttpContext.Session.GetInt32("num");
        ViewBag.Num = num;
        Console.WriteLine(ViewBag.Num);
        string? userName = HttpContext.Session.GetString("userName");
        return View("Dashboard", userName);
    }
    [HttpGet("/Dashboard/minusone")]
    public IActionResult MinusOne()
    {
        int? sessNum = HttpContext.Session.GetInt32("num");
        int newNum = (int)sessNum - 1;
        HttpContext.Session.SetInt32("num", newNum);
        int? num = HttpContext.Session.GetInt32("num");
        ViewBag.Num = num;
        Console.WriteLine(ViewBag.Num);
        string? userName = HttpContext.Session.GetString("userName");
        return View("Dashboard", userName);
    }
    [HttpGet("/Dashboard/timestwo")]
    public IActionResult TimesTwo()
    {
        int? sessNum = HttpContext.Session.GetInt32("num");
        int newNum = (int)sessNum * 2;
        HttpContext.Session.SetInt32("num", newNum);
        int? num = HttpContext.Session.GetInt32("num");
        ViewBag.Num = num;
        Console.WriteLine(ViewBag.Num);
        string? userName = HttpContext.Session.GetString("userName");
        return View("Dashboard", userName);
    }
    [HttpGet("/Dashboard/addrand")]
    public IActionResult AddRand()
    {
        Random rand = new Random();
        int randNum = rand.Next(1, 11);
        int? sessNum = HttpContext.Session.GetInt32("num");
        int? newNum = (int)sessNum + randNum;
        HttpContext.Session.SetInt32("num", newNum);
        int? num = HttpContext.Session.GetInt32("num");
        ViewBag.Num = num;
        Console.WriteLine(ViewBag.Num);
        string? userName = HttpContext.Session.GetString("userName");
        return View("Dashboard", userName);
    }

    [HttpGet("Dashboard")]
    public IActionResult Dashboard()
    {
        if (HttpContext.Session.GetString("userName") == null)
        {
            return RedirectToAction("Index");
        }
        HttpContext.Session.SetInt32("num", 22);
        int? number22 = HttpContext.Session.GetInt32("num");
        ViewBag.num = number22;
        string? userName = HttpContext.Session.GetString("userName");
        return View("Dashboard", userName);
    }

    // logout route
    [HttpPost("user/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
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
