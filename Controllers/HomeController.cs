using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;

namespace PersonalPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewBag.Introduction = "I'm a C# developer passionate about building web applications.";
        ViewBag.YearsExperience = 5;
        ViewBag.Location = "Pretoria";
        
        return View();
    }

    [ResponseCache(Duration = 1, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
