using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private WeddingPlannerContext db;
        public WeddingController(WeddingPlannerContext context)
        {
            db = context;
        }
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> AllWeddings = db.Weddings
            .Include(wedding => wedding.Rsvps)
            .ToList();
            return View("Dashboard", AllWeddings);
        }

        // 1. handles GET request to DISPLAY the form used to create a new Post
        [HttpGet("/wedding/add")]
        public IActionResult AddWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("AddWedding");
        }

        [HttpPost("/wedding/create")]
        public IActionResult CreateWedding (Wedding newWedding)
        {
            if (ModelState.IsValid == false)
            {
                return View("AddWedding");
            }

            if (newWedding.Date <= DateTime.Now)
            {
                ModelState.AddModelError("Date", "must be in the future.");
                return View("AddWedding");
            }

            newWedding.UserId = (int)uid;
            db.Weddings.Add(newWedding);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("/dashboard/{weddingId}/respond")]
        public IActionResult Respond(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Rsvp existingRespond = db.Rsvps
                .FirstOrDefault(like => like.UserId == (int)uid && like.WeddingId == weddingId);

            if (existingRespond == null)
            {
                Rsvp rsvp = new Rsvp()
                {
                    WeddingId = weddingId,
                    UserId = (int)uid
                };

                db.Rsvps.Add(rsvp);
            }
            else
            {
                db.Rsvps.Remove(existingRespond);
            }


            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("/dashboard/{weddingId}/delete")]
        public IActionResult Delete(int weddingId)
        {

            Wedding wedding = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            // If wedding not found OR user is not the creator, redirect them.
            if (wedding == null || wedding.UserId != uid)
            {
                return RedirectToAction("Index", "Home");
            }
            
            db.Weddings.Remove(wedding);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/details/{weddingId}")]
        public IActionResult WeddingDetails(int weddingId)
        {
            Wedding wedding = db.Weddings
            .Include(wedding => wedding.Rsvps)
            .ThenInclude(rsvp => rsvp.User)
            .FirstOrDefault(w => w.WeddingId == weddingId);;

            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("WeddingDetails", wedding);
        }
    }
}