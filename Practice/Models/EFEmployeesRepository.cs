using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class EFEmployeesRepository : IEmployeesRepository
    {
        private EmployeesDbContext context;

        public EFEmployeesRepository(EmployeesDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employee> Employees => context.Employees;
    }
}
