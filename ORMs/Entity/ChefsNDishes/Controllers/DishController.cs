using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers;

public class DishController : Controller
{
    private MyContext db;
    public DishController(MyContext context)
    {
        db = context;
    }

    [HttpGet("/dishes/all")]
    public IActionResult AllDishes()
    {
        List<Dish> allDishes = db.Dishes.ToList();

        return View("AllDishes", allDishes);
    }

    [HttpGet("/dishes/create")]
    public IActionResult CreateDish()
    {
        ViewBag.allChefs = db.Chefs.ToList();
        return View("NewDish");
    }

    [HttpPost("/dishes/add")]

    public IActionResult AddDish(Dish newDish)
    {
        if (!ModelState.IsValid)
        {
            return View("NewDish");
        }
        db.Dishes.Add(newDish);
        db.SaveChanges();
        return RedirectToAction("AllDishes");
    }
}