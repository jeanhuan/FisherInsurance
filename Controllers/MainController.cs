using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;
public class MainController : Controller

{
    public IActionResult Index()

    {
       // return Ok("This is the index of the HomeController");

       return View();

    }
    
    public IActionResult Quote()

    {

        Quote quote = new Quote {

            Id = 345,

            Product = "Home Insurance",

            ExpireDate = DateTime.Now.AddDays(45),

            Price = 45.00M

        };

       // return Ok("This is the quote for the HomeController");

       return View(quote);

    }
}