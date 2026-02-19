using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_registration.Models;

namespace Student_registration.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

        public string  Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "Student Registered successfully!";
            }
        }
    }
}
