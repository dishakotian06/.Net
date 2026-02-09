using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace registration.Controllers
{
    public class registerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Register user)
        {
            return Content(
                $"Registration Succesful\nName:{user.Name}\nEmail: {user.Email}\n Age:{user.Age}"
                );
        }
        return View(user);
    }
}
}