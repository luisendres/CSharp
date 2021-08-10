using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // display all Womens' Leagues
            ViewBag.WomenLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Womens'"))
                .ToList();
            // display all Hockey Leagues
            ViewBag.HockeyLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"))
                .ToList();
            // display all sports that's not football
            ViewBag.NoFootballLeagues = _context.Leagues
                .Where(l => !l.Sport.Contains("Football"))
                .ToList();
            // display leagues that have conferences in their Name
            ViewBag.ConferenceLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Conference"))
                .ToList();
            // display leagues from Atlanta
            ViewBag.AtlanticLeagues = _context.Leagues
                .Where(l => l.Name.Contains("Atlantic"))
                .ToList();
            // display Teams from Dallas
            ViewBag.DallasTeams = _context.Teams
                .Where(t => t.Location.Contains("Dallas"))
                .ToList();
            // display teams named Raptors
            ViewBag.RaptorTeams = _context.Teams
                .Where(t => t.TeamName.Contains("Raptors"))
                .ToList();
            // display teams whose location includes "City"
            ViewBag.CityTeams = _context.Teams
                .Where(t => t.Location.Contains("City"))
                .ToList();
            // display teams whose name starts with "T"
            ViewBag.TTeams = _context.Teams
                .Where(t => t.TeamName.StartsWith("T"))
                .ToList();
            // display teams loacation in alphabetical order by location
            ViewBag.TeamsAlphabeticalLocation = _context.Teams
                .OrderBy(t => t.Location);
            // display teams name in reverse alphabetical order by location
            ViewBag.ReverseAlphabeticalTeams = _context.Teams
                .OrderByDescending(t => t.TeamName);
            // display players with the last name "Cooper"
            ViewBag.LastNameCooper = _context.Players
                .Where(p => p.LastName.Contains("Cooper"))
                .ToList();
            // display players with the first name "Joshua"
            ViewBag.FirstNameJoshua = _context.Players
                .Where(p => p.FirstName.Contains("Joshua"))
                .ToList();
            // display players with the last name "Cooper", except Joshua
            ViewBag.LastNameCooperNoJoshua = _context.Players
                .Where(p => p.LastName.Contains("Cooper") && !p.FirstName.Contains("Joshua"))
                .ToList();
            // display players with the first name "Alexander" or "Wyatt"
            ViewBag.FirstNameAlexanderOrWyatt = _context.Players
                .Where(p => p.FirstName.Contains("Alexander") || p.FirstName.Contains("Wyatt"))
                .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}