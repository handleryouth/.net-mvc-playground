using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Utils;


public class FormsController : Controller
{

    public IActionResult Index()
    {
        MovieForms movieForms = new() { Year = "2024", Description = "This is movie description", Name = "" };
        return View(movieForms);
    }

    [HttpPost]
    public IActionResult Index(MovieForms model)
    {
        Console.WriteLine("model" + model);
        Console.Write("model name: " + model.Name);
        return View(model);
    }


    public IActionResult Login()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> LoginAsync(LoginForms LoginModel)
    {


        Console.WriteLine("email: " + LoginModel.Email);
        Console.WriteLine("password: " + LoginModel.Password);

        if (!ModelState.IsValid)
        {
            return View(LoginModel);
        }


        RequestClient client = new();



        var response = await client.PostTask("login", LoginModel);

        Console.WriteLine("response" + response);
        return View();
    }

}