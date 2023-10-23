using AssignmentOnMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentOnMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {
              new Product { Id = 1,Name="PenDrive",Price=899},
              new Product { Id = 2,Name="Laptop",Price=45000},
              new Product { Id = 3,Name="Tv",Price=28500},
              new Product { Id = 4,Name="Mouse",Price=620},
              new Product { Id = 5,Name="AC",Price=25000},

            };
            ViewData["message"] = "This is product list";
            ViewBag.Products = products;
            return View();
            
        }
    }
}
