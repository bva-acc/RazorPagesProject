using RazorPagesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorPagesProject.Services
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public Employee DeleteEmployee(int id)
        {
            var employeeToDelete = _context.Employees.Find(id);
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
            return employeeToDelete;
        }

        public IEnumerable<DepartmentHeadCount> EmployeeCountByDepartment(Department? department)
        {
            IEnumerable<Employee> query = _context.Employees;
            if (department.HasValue)
            {
                query = query.Where(x => x.Department == department.Value);
            }

            return query.GroupBy(x => x.Department)
                .Select(x => new DepartmentHeadCount()
                {
                    Department = x.Key.Value,
                    Count = x.Count()
                }).ToList();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public IEnumerable<Employee> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return _context.Employees;
            }
            return _context.Employees.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.ToLower().Contains(searchTerm.ToLower()));
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            var employee = _context.Employees.Attach(updatedEmployee);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedEmployee;
        }
    }
}
