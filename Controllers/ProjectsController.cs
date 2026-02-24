using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Personal_Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<ProjectItem>
            {
                new ProjectItem
                {
                    Title = "Personal Portfolio Website",
                    Description = "A responsive portfolio website built with ASP.NET Core MVC to showcase my projects and skills.",
                    Technologies = new List<string> { "ASP.NET Core", "C#", "HTML", "CSS", "JavaScript" }
                },
                new ProjectItem
                {
                    Title = "E-commerce Platform",
                    Description = "An online store application with features like product listing, shopping cart, and user authentication.",
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework", "SQL Server", "Bootstrap" }
                },
                new ProjectItem
                {
                    Title = "Task Management App",
                    Description = "A web application for managing tasks and to-do lists with user-friendly interface and real-time updates.",
                    Technologies = new List<string> { "ASP.NET Core", "SignalR", "React", "MongoDB" }
                }
            };

            //Attach the list to ViewBag
            ViewBag.Projects = projects;

            return View(projects);
        }
    }
}