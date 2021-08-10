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
        [HttpPost("DojoSurvey/result")]
        public IActionResult ResultProcess(User newUser)
        {
            if(ModelState.IsValid)
            {
                return View("Result", newUser);
            }
            else
            {
                return View("Index");
            }
        }
    }
}