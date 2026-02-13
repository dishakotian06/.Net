using Microsoft.AspNetCore.Mvc;
using razor.Models;

namespace razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<product> products = new List<product>
            {
                new Models.product {Id= 1, Name= "laptop", Price=55000},
                new Models.product {Id= 2, Name=" mobile", Price=25000},
                new Models.product {Id= 3, Name= "Headphones",Price=3000}
            };
            return View(products);
        }
    }
}


