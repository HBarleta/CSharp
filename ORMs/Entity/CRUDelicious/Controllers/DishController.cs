using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private MyContext db;

    public DishController(MyContext context)
    {
        db = context;
    }

    // new dish form
    [HttpGet("/dishes/new")]
    public IActionResult NewDish()
    {
        return View("New");
    }

    // add a new dish
    [HttpPost("/dishes/create")]
    public IActionResult AddDish(Dish newDish)
    {
        if (!ModelState.IsValid)
        {
            return NewDish();
        }
        // form should be valid at this point
        db.Dishes.Add(newDish);
        // adds new dish to DB
        db.SaveChanges();
        // saves changes to DB
        return RedirectToAction("All");
        // Redirects to All page
    }

    // Get all dishes
    [HttpGet("/dishes")]
    public IActionResult All()
    {
        // create a list of Dish objects
        List<Dish> allDishes = db.Dishes.ToList();
        // return View passing in allDishes object to be used in All page
        return View("All", allDishes);
    }
    // Get one dish
    [HttpGet("/dishes/{dishId}")]
    public IActionResult Details(int dishId)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        // check if dishId is valid in DB
        if (dish == null)
        {
            // if dishID is invalid, return to all page
            return View("All");
        }
        // otherwise return View Details page passing in dish object that was pulled from DB
        return View("Details", dish);
    }
    // Delete a dish
    [HttpPost("/dishes/{dishId}/delete")]
    public IActionResult Delete(int dishId)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        // check if dishId is valid in DB
        if (dish != null)
        {
            // if ID is valid, remove dish
            db.Dishes.Remove(dish);
            db.SaveChanges();
        }
        // invalid or not we return back to all
        return RedirectToAction("All");
    }

    [HttpPost("/dishes/{dishId}/edit")]
    public IActionResult Edit(int dishId)
    {
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        // check if dishId is valid in DB
        if (dish == null)
        {
            // if dishID is invalid, return to all page
            return View("All");
        }
        // otherwise return View Details page passing in dish object that was pulled from DB
        return View("Edit", dish);
    }

    [HttpPost("/dishes/{dishId}/update")]
    public IActionResult Update(int dishId, Dish editedDish)
    {
        if (!ModelState.IsValid)
        {
            // reuse Edit route functionality passing in dishId
            // make sure the Edit method does not have a default View()
            return Edit(dishId);
        }
        Dish? dbdish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if (dbdish == null)
        {
            return RedirectToAction("All");
        }
        dbdish.Name = editedDish.Name;
        dbdish.Chef = editedDish.Chef;
        dbdish.Tastiness = editedDish.Tastiness;
        dbdish.Calories = editedDish.Calories;
        dbdish.Description = editedDish.Description;
        dbdish.UpdatedAt = DateTime.Now;

        db.Dishes.Update(dbdish);
        db.SaveChanges();
        return RedirectToAction("Details", new { dishId = dishId });

    }

}