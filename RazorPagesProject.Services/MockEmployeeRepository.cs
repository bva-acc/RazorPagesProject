using RazorPagesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorPagesProject.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0,
                    Name = "Aaron",
                    Email = "aaron@example.com",
                    PhotoPath = "empimage0.png",
                    Department = Department.IT
                },
                new Employee()
                {
                    Id = 1,
                    Name = "Bob",
                    Email = "bob@example.com",
                    PhotoPath = "empimage1.png",
                    Department = Department.IT
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Lisa",
                    Email = "lisa@example.com",
                    PhotoPath = "empimage2.png",
                    Department = Department.Accounting
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Kate",
                    Email = "kate@example.com",
                    PhotoPath = "empimage3.png",
                    Department = Department.None
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Sarah",
                    Email = "sarah@example.com",
                    Department = Department.IT
                }
            };
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            newEmployee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(newEmployee);
            return newEmployee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
                employee.PhotoPath = updatedEmployee.PhotoPath;
            }
            return employee;
        }
    }
}
