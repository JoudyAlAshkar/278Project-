using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;

namespace _278Project.Controllers;

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
    public IActionResult AboutUs()
    {
        return View();
    }
    public IActionResult BabyCare()
    {
        return View();
    }
    public IActionResult Beauty()
    {
        return View();
    }
    public IActionResult Food()
    {
        return View();
    }
    public IActionResult FruitesAndVeggies()
    {
        return View();
    }
    public IActionResult Gardening()
    {
        return View();
    }
    public IActionResult Office()
    {
        return View();
    }
    public IActionResult NewArrivals()
    {
        return View();
    }
    public IActionResult BestSellers()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
