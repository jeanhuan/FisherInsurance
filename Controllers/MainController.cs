using Microsoft.AspNetCore.Mvc;

public class MainController : Controller

{
    public IActionResult Index()

    {
       // return Ok("This is the index of the HomeController");

       return View();

    }
    
    public IActionResult Quote()

    {
        return Ok("This is the quote of the HomeController");
    }
}