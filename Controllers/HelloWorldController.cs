using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name = "tony", int numTimes = 1)
    {
        ViewData["Message"] = $"hello {name}!";
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public string Test()
    {
        return "This is the test action method...";
    }
}