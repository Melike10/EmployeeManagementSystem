using Entities.Concrete;
using Entitities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EmployeeDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NKTDPLS\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OffDay> Offdays { get; set; }
        public DbSet<PayrollParameter> PayrollParameters { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
    }
}
