using System.ComponentModel.DataAnnotations;

namespace Student_registration.Models
{
    public class Student
    {
        [Required] public string Name { get; set; }

        [Required] public int Id { get; set; }

        [Required] public int Age { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
    
        
    }
}
