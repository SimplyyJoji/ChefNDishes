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
    public class DishController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private ChefNDishesContext db;
        public DishController(ChefNDishesContext context)
        {
            db = context;
        }

        [HttpGet("/new/dish")]
        public IActionResult NewDish()
        {
            return View("NewDish");
        }


        [HttpPost("/dish/create")]
        public IActionResult CreateDish(Dish newDish)
        {
             // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("NewDish");
            }
            // The above return did not happen so ModelState IS valid.
            db.Dishes.Add(newDish);
            // db doesn't update until we run save changes
            // after SaveChanges, our newPost object now has it's PostId updated from db auto generated id
            db.SaveChanges();

            return View("Index");
        }
    }
}