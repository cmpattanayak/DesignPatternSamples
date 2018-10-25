using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Presentation.Models
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext (DbContextOptions<EmployeeDataContext> options)
            : base(options)
        {
        }

        public DbSet<DesignPattern.Presentation.Models.Employee> Employee { get; set; }
        public DbSet<DesignPattern.Presentation.Models.EmployeeType> EmployeeType { get; set; }
    }
}
