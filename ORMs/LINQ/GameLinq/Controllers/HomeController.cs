using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameLinq.Models;

namespace GameLinq.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<int> numbers = new List<int>() {
            5,15,20,0,1,3,25
        };
        // parameter(num) => predicate (num > 10)
        // predicate will evaluate to a boolean expression
        // parameter should be a singular version of the list (numbers // num)
        List<int> numsAboveTen = numbers.Where(n => n > 10).ToList();
        // same as this ^^
        // foreach(int number in numbers){
        //     if(number > 10){
        //         numsAboveTen.Add(number);
        //     }
        // }
        List<string> names = new List<string>() {
            "Jerry", "Barry", "Jacob", "Mark", "Jason"
        };
        // selector = names.Min( name => name.Length)
        int shortestNameLength = names.Min(name => name.Length);
        Console.WriteLine($"Shortest name length = {shortestNameLength}");
        return View();
        
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
