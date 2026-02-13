using Microsoft.AspNetCore.Mvc;

namespace RoutingDemoMvc.Controllers
{             
    public class StudentController : Controller
    {                  
        [Route("Input/{id}")]
        public IActionResult Input(int id, string name)
        {
            string message = $"Student ID: {id}, Student Name: {name}";
            return Content(message);
        }
        
    }
}
