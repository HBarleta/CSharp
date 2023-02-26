using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;
namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private MyContext db;
    public WeddingController(MyContext context)
    {
        db = context;
    }
    // list of weddings
    [SessionCheck]
    [HttpGet("/weddings")]
    public IActionResult All()
    {
        List<Wedding>? allPlannedWeddings = db.Weddings.Include(w => w.Planner).Include(w => w.Guests).ToList();
        return View("All", allPlannedWeddings);
    }
    // form to create a wedding
    [SessionCheck]
    [HttpGet("/weddings/create")]
    public IActionResult CreateWedding()
    {

        return View("New");
    }
    // add wedding to DB
    [SessionCheck]
    [HttpPost("/weddings/add")]
    public IActionResult AddWedding(Wedding newWedding)
    {
        if (!ModelState.IsValid)
        {
            return View("New");
        }
        // adding userId to wedding entry
        newWedding.UserId = (int)HttpContext.Session.GetInt32("UUID");
        db.Weddings.Add(newWedding);
        db.SaveChanges();
        return RedirectToAction("All");
    }
    // view a specific wedding
    [SessionCheck]
    [HttpGet("/weddings/{wedId}")]
    public IActionResult ViewOne(int wedId)
    {
        // retrieving wedding info from DB and including a list of guests 
        Wedding? wedding = db.Weddings.Include(w => w.Guests).ThenInclude(g => g.User).FirstOrDefault(w => w.WeddingId == wedId);
        if (wedding == null)
        {
            return RedirectToAction("All");
        }
        return View("ViewWedding", wedding);
    }
    // delete function for weddings created by user
    [SessionCheck]
    [HttpPost("/weddings/{wedId}/delete")]
    public IActionResult DeleteWedding(int wedId)
    {
        Wedding? wedding = db.Weddings.FirstOrDefault(wed => wed.WeddingId == wedId);
        // checks if wedding exists and if the logged it user was the creator
        if (wedding != null && wedding.UserId == (int)HttpContext.Session.GetInt32("UUID"))
        {
            db.Weddings.Remove(wedding);
            db.SaveChanges();
        }
        return RedirectToAction("All");
    }

    [SessionCheck]
    [HttpPost("/weddings/{wedId}/rsvp")]
    public IActionResult RSVP(int wedId)
    {
        GuestsRSVPWedding? isAttending = db.GuestsRSVPWeddings.FirstOrDefault(grw => grw.UserId == HttpContext.Session.GetInt32("UUID") && grw.WeddingId == wedId);
        if (isAttending == null)
        {
            GuestsRSVPWedding newRSVP = new GuestsRSVPWedding()
            {
                UserId = (int)HttpContext.Session.GetInt32("UUID"),
                WeddingId = wedId
            };
            db.GuestsRSVPWeddings.Add(newRSVP);
        }
        else
        {
            db.GuestsRSVPWeddings.Remove(isAttending);
        }
        db.SaveChanges();
        return RedirectToAction("All");
    }
}

// session check attribute to ensure users cannot navigate to these routes unless they are logged in
public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        int? userId = context.HttpContext.Session.GetInt32("UUID");
        // checks if a valid userId is stored in session
        if (userId == null)
        {
            // if it is null it will redirect to index page for login
            context.Result = new RedirectToActionResult("Index", "User", null);
        }
    }
}
