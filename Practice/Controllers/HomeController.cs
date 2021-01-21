using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeesRepository repository;
        public int PageSize = 3;

        public HomeController(IEmployeesRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(int employeePage = 1)
            => View(repository.Employees
                .OrderBy(p => p.ID)
                .Skip((employeePage - 1) * PageSize)
                .Take(PageSize)
                );
    }
}
