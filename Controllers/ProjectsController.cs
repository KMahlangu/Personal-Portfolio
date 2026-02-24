using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Personal Portfolio";
            ViewBag.Description = "This project was created to give an overview of my portfolio and all the things that I have achieved since I started this journey of IT.";
            ViewBag.Technologies = "AspNetCore, MVC framework, Javascript";
            return View();
        }

        public IActionResult Details()
        {
            return Content("My projects: Personal Portfolio, Calculator, My First Static Website");
        }

        public IActionResult Timeline()
        {
            return Content("The Project will take me 3 months to complete.");
        }
    }
}