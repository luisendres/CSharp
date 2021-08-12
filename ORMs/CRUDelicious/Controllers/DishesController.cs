using System;
using System.Linq;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDelicious.Controllers
{
    public class DishesController : Controller
    {
        private CRUDeliciousContext db;
        public DishesController(CRUDeliciousContext context)
        {
            db = context;
        }

        // 1. handles GET request to DISPLAY the form used to create a new Post
        [HttpGet("/new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("/create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid == false)
            {
                // Go back to the form so errror messages are displayed.
                return View("New");
            }

            db.Dishes.Add(newDish);

            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [HttpGet("/edit/{dishId}")]
        public IActionResult Details (int dishId)
        {
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (dish == null)
            {
                return RedirectToAction("Index","Home");
            }

            return View("Details", dish);
        }

        [HttpPost("/edit/{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            
            if (dish == null)
            {
                RedirectToAction("Index","Home");
            }

            db.Dishes.Remove(dish);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [HttpGet("/edit/{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (dish == null)
            {
                return RedirectToAction("Index","Home");
            }

            return View("Edit", dish);
        }

        [HttpPost("/edit/{dishId}/update")]
        public IActionResult Update(int dishId, Dish editedDish)
        {
            if (ModelState.IsValid == false)
            {
                editedDish.DishId = dishId;
                return View("Edit", editedDish);
            }

            Dish dbDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (dbDish == null)
            {
                return RedirectToAction("Index","Home");
            }

            dbDish.Name = editedDish.Name;
            dbDish.Chef = editedDish.Chef;
            dbDish.Tastiness = editedDish.Tastiness;
            dbDish.Calories = editedDish.Calories;
            dbDish.Description = editedDish.Description;
            dbDish.UpdatedAt = DateTime.Now;
            
            db.Dishes.Update(dbDish);
            db.SaveChanges();

            return RedirectToAction("Details", new { dishId = dishId});
        }
    }
}