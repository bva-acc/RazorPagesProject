using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPagesProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name field cannot be empty!")]
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email format")]
        [MaxLength(50), MinLength(2)]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Department? Department { get; set; }
    }
}
