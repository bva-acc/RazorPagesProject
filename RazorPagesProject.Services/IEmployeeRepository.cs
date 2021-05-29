﻿using RazorPagesProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesProject.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
