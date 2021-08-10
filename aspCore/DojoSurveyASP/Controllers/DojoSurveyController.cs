// using System;
// using System.Collections.Generic;
using DojoSurveyASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyASP.Controllers
{
    public class DojoSurvey : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        // remember to use [HttpPost] attributes!
        [HttpPost("result")]
        public IActionResult ResultProcess(User newUser)
        {
            return View("Result", newUser);
        }
    }
}