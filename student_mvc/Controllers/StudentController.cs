using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using student_mvc.Models;

namespace student_mvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student {USN=01,mark1=98,mark2=87,mark3=90},
                new Student {USN=01,mark1=99,mark2=85,mark3=97},
                new Student  {USN=01,mark1=78,mark2=83,mark3=94},

            };
            return View(students);
        }
    }
}
