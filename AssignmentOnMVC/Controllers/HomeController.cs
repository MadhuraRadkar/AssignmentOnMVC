using AssignmentOnMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssignmentOnMVC.Controllers
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
            List<string> colours = new List<string>()
            {
                "Blue","Purple","Grey","Black","Pink","Red","Black"
            };
            ViewData["List"]=colours;
            return View();
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