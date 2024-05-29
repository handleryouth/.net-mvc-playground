using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;
public class ErrorController : Controller
{
    [ActionName("500")]
    public IActionResult InternalServerError()
    {
        return View();
    }

    [ActionName("404")]
    public IActionResult PageNotFound()
    {
        return View();
    }
}