using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
namespace WeddingPlanner.Controllers;

public class UserController : Controller
{
    private MyContext db;
    public UserController(MyContext context)
    {
        db = context;
    }
    // main page that uses 2 partials containing login or registration form
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
    }

    // registers user to DB if all fields are met
    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        // hashes password to be stored in DB 
        PasswordHasher<User> hasher = new PasswordHasher<User>();
        newUser.Password = hasher.HashPassword(newUser, newUser.Password);
        db.Users.Add(newUser);
        db.SaveChanges();
        // userId and user's first name is stored in session to be used later
        HttpContext.Session.SetInt32("UUID", newUser.UserId);
        HttpContext.Session.SetString("UserName", newUser.FirstName);
        return RedirectToAction("All", "wedding");
    }

    [HttpPost("/login")]
    public IActionResult Login(LoginUser userSubmission)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        // finds user in DB 
        User? userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
        if (userInDb == null)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View("Index");
        }
        // verifying hashed PW to see if it matches PW for userInDb 
        PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
        var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
        if (result == 0)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View("Index");
        }
        // saving userID and user first name in session
        HttpContext.Session.SetInt32("UUID", userInDb.UserId);
        HttpContext.Session.SetString("UserName", userInDb.FirstName);
        return RedirectToAction("All", "wedding");
    }
    // logs user out and returns to index page
    [HttpPost("user/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}