using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Department? Department { get; set; }
    }
}
