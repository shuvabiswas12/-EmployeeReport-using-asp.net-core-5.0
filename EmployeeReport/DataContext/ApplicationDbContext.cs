using EmployeeReport.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReport.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // here we just push or passed a reference an object name option to a base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
