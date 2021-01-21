using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Practice.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeesDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeesDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Kayak",
                        Age = 20,
                        Address = "Ha Noi",
                        Email = "Kayak@gmail.com"
                    },
                    new Employee
                    {
                        Name = "Peter",
                        Age = 22,
                        Address = "Ha Noi",
                        Email = "Peter@gmail.com"
                    },
                    new Employee
                    {
                        Name = "Linda",
                        Age = 20,
                        Address = "Ha Giang",
                        Email = "Linda@gmail.com"
                    },
                    new Employee
                    {
                        Name = "Mark",
                        Age = 23,
                        Address = "Hai Phong",
                        Email = "Mark@gmail.com"
                    },
                    new Employee
                    {
                        Name = "Dan",
                        Age = 21,
                        Address = "Ha Noi",
                        Email = "Dan@gmail.com"
                    },
                    new Employee
                    {
                        Name = "Marco",
                        Age = 20,
                        Address = "Ninh Binh",
                        Email = "Marco@gmail.com"
                    }
                    );
                context.SaveChanges();
            }
        }

    }
}

