using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

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
    [HttpGet("/message")]
    public IActionResult Message()
    {
        Message message1 = new Message()
        {
            newMessage = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Officia accusantium a consectetur vitae molestiae sequi nam incidunt, corporis nihil labore reprehenderit ex provident porro, voluptatem ad sapiente ratione suscipit. Expedita."
        };
        return View("Message", message1);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        Number numsList = new Number()
        {
            nums = new List<int>() { 1, 25, 33, 55, 230, 5448, 1, -54, 5468 }
        };
        return View("Numbers", numsList);
    }

    [HttpGet("/user")]
    public IActionResult User()
    {
        User newUser = new User()
        {
            FirstName = "Harold",
            LastName = "Barleta"
        };
        return View("User", newUser);
    }

    [HttpGet("/userlist")]

    public IActionResult UserList()
    {
        UserList newList = new UserList()
        {
            userList = new List<string>() { "Harold Barleta", "Lebron James", "Walker Texas Ranger", "Medicine Woman", "John Cena", "Elon Tusk" }
        };
        return View("UserList", newList);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
