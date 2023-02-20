using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
namespace ChefsNDishes.Controllers;

public class ChefController : Controller
{
    private MyContext db;
    public ChefController(MyContext context)
    {
        db = context;
    }
    [HttpGet("/")]
    [HttpGet("/chefs/all")]
    public IActionResult AllChefs()
    {
        List<Chef> allChefs = db.Chefs.ToList();
        return View("AllChefs", allChefs);
    }

    [HttpGet("/chefs/create")]
    public IActionResult CreateChef()
    {
        return View("NewChef");
    }
    [HttpPost("chefs/add")]

    public IActionResult AddChef(Chef newChef)
    {
        if (!ModelState.IsValid)
        {
            return View("NewChef");
        }
        db.Chefs.Add(newChef);
        db.SaveChanges();
        return RedirectToAction("AllChefs");
    }
}