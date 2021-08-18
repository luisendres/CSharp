using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ChefsAndDishesContext db;
        public HomeController(ChefsAndDishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> allChefs = db.Chefs
            .Include(chef => chef.Dishes)
            .ToList();
            return View("Index", allChefs);
        }

        [HttpGet("/dishes")]
        public IActionResult Dishes()
        {
            List<Dish> allDishes = db.Dishes
            .Include(dish => dish.Author)
            .ToList();
            return View("Dishes", allDishes);
        }

        [HttpGet("/new")]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }

        [HttpPost("/new/create")]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid == false)
            {
                // Back to form to display errors.
                return View("AddChef");
            }

            if (newChef.Date >= DateTime.Now)
            {
                ModelState.AddModelError("Date", "Invalid Date.");
                return View("AddChef");
            }
            if(newChef.Age() < 18)
            {
                ModelState.AddModelError("Date", "must be over 18.");
                return View("AddChef");
            }

            if(newChef.Age() > 150)
            {
                ModelState.AddModelError("Date", "Highly doubt you are over 150 years old.");
                return View("AddChef");
            }

            db.Chefs.Add(newChef);
            db.SaveChanges();
            return RedirectToAction ("Index");
        }

        [HttpGet("/dishes/new")]
        public IActionResult AddDish()
        {
            List<Chef> AllChefs = db.Chefs.ToList();
            ViewBag.allChefs = AllChefs;
            return View("AddDish");
        }

        [HttpPost("/dishes/new/create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if (ModelState.IsValid == false)
            {
                List<Chef> AllChefs = db.Chefs.ToList();
                ViewBag.allChefs = AllChefs;
                return View("AddDish");
            }

            db.Dishes.Add(newDish);
            db.SaveChanges();
            return RedirectToAction ("Index");
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
