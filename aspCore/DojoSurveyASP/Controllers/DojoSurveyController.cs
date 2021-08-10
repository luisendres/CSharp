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
        [HttpPost("method")]
        public IActionResult Method(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Result");
        }
    }
}