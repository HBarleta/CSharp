using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers;

public class UserController : Controller
{

    private MyContext db;
    public UserController(MyContext context)
    {
        db = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        // new password hasher instance
        PasswordHasher<User> hasher = new PasswordHasher<User>();
        // hashes password
        newUser.Password = hasher.HashPassword(newUser, newUser.Password);
        db.Users.Add(newUser);
        db.SaveChanges();
        HttpContext.Session.SetInt32("UUID", newUser.UserId);
        return RedirectToAction("Dashboard");
    }

    [HttpPost("/login")]
    public IActionResult Login(UserLogin userSubmission)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        User? userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
        if (userInDb == null)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View("Index");
        }
        PasswordHasher<UserLogin> hasher = new PasswordHasher<UserLogin>();
        var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
        if (result == 0)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View("Index");
        }
        HttpContext.Session.SetInt32("UUID", userInDb.UserId);
        return RedirectToAction("Dashboard");
    }


    [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {

        return View("Dashboard");
    }
    [HttpPost("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}
