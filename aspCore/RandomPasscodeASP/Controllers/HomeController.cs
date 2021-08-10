using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscodeASP.Models;

namespace RandomPasscodeASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int? count = HttpContext.Session.GetInt32("count");
            if (count == null)
            {
                HttpContext.Session.SetInt32("count", 1);
            }
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            return View("Index");
        }

        [HttpPost("Home/result")]
        public IActionResult Result(RandomPasscode newRandomPasscode)
        {
            Random rand = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string Passcode = "";
            
            for (int i = 1; i <= 14; i++)
            {
                Passcode += chars[rand.Next(chars.Length)];
            }
            string updatedCode = HttpContext.Session.GetString("passcode");
            updatedCode = Passcode;
            HttpContext.Session.SetString("passcode", updatedCode);

            int? total = HttpContext.Session.GetInt32("count");
            total += 1;
            HttpContext.Session.SetInt32("count", (int)total);
            return RedirectToAction("Index");
        }

        [HttpPost("/restart")]
        public RedirectToActionResult Restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
