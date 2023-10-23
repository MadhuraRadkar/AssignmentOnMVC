using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentOnMVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult CreateCourse()
        {
            List<string> option = new List<string>()
            {
              "Yes","No"
            };
            ViewData["option"] = new SelectList(option);
            return View();
        }
        [HttpPost]
        public IActionResult CreateCourse(IFormCollection form, ICollection<string> CourseInterested)
        {
            ViewBag.Name = form["name"];
            ViewBag.Gender = form["gender"];
            ViewBag.Course = CourseInterested;
            ViewBag.Details = form["option"];
            return View("DisplayDetails");
        }
    }
}
