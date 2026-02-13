using System.Diagnostics;
using Interface_Custom_service.Models;
using Interface_Custom_service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Interface_Custom_service.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _greet;

        public HomeController(IMyService greet)
        {
            _greet = greet;
        }

        public IActionResult Index()
        {
            var message = _greet.Getmessage("Disha");
            ViewBag.Message = message;
            return View();
        }

        
    }
}
