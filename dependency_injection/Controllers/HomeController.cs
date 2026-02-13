using System.Diagnostics;
using Dependency_injection.Models;
using Dependency_injection.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _service;

        public HomeController(IMyService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);
        }

    }
}
