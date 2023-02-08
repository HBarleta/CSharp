using Microsoft.AspNetCore.Mvc;
// inherits from the base controller class so that our controllers inheirit
// helpful methods for handling the HTTP request/response cycle
public class HomeController : Controller
{
    // Attribute, HTTP type and route URL
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("/videos")]

    public ViewResult Videos()
    {
        List<string> YouTubeVidIds = new List<string>() { "gVq3HyDkZ84" };
        ViewBag.VideoIds = YouTubeVidIds;
        ViewBag.Message = "Hello from ViewBag";

        return View("Videos");
    }

}