using Microsoft.AspNetCore.Mvc;
using RazorPagesProject.Models;
using RazorPagesProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProject.ViewComponents
{
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Department? department = null)
        {
            var result = _employeeRepository.EmployeeCountByDepartment(department);
            return View(result); // возвращаем представление с моделью
        }
    }
}
