using RazorPagesProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesProject.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee UpdateEmployee(Employee updatedEmployee);
        Employee AddEmployee(Employee newEmployee);
        Employee DeleteEmployee(int id);
    }
}
