using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefNDishes.Models;

namespace ChefNDishes.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private ChefNDishesContext db;
        public HomeController(ChefNDishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet("/new")]
        public IActionResult NewUser()
        {
            return View("NewChef");
        }
        

        [HttpPost("/new")]
        public IActionResult CreateUser()
        {
            return View("Index");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
