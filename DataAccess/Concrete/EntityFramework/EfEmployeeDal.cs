using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EmployeeDbContext>, IEmployeeDal
    {
        //private readonly EmployeeDbContext _context;

        //public EfEmployeeDal(EmployeeDbContext context)
        //{
        //    _context = context;
        //}
        //public void Add(Employee employee)
        //{
        //    _context.Employees.Add(employee);
        //    _context.SaveChanges();

        //}

        //public List<Employee> GetAll()
        //{
        //    return _context.Employees.ToList();
        //}
        public EfEmployeeDal(EmployeeDbContext context) : base(context)
        {
        }

        public List<EmployeeDto> GetEmployeeList()
        {
            using (var context = new EmployeeDbContext())
            {
                var res = from employee in context.Employees
                          join department in context.Departments on employee.DepartmentId equals department.Id
                          select new EmployeeDto
                          {
                              Id = employee.Id,
                              Name = employee.Name + " " + employee.LastName,
                              BirthDate = employee.BirthDate,
                              Salary = employee.Salary,
                              StartingDate = employee.StartingDate,
                              ReasonOfLeaving = employee.ReasonOfLeaving,
                              EndingDate = employee.EndingDate,
                              IdentitiyNumber = employee.IdentitiyNumber,
                              DepartmentId = employee.DepartmentId,
                              DepartmentName = department.Name,
                              Status = employee.Status,
                              // burada selectteki s. date önünde cascandig yaparak null dönmesini sağladım (DateTime?)
                              OffDayEndDate = context.Offdays.Where(o => o.EmployeeId == employee.Id).OrderByDescending(x => x.Date).Select(s => (DateTime?)s.Date).FirstOrDefault()

                          };

                return res.ToList();

            }
        }

        public List<EmployeeOffDayDto> GetEmployeeOffDayList()
        {
            using (var context = new EmployeeDbContext())
            {
                var res = from employee in context.Employees.Where(e => e.Status != "İşten Ayrıldı")
                          join department in context.Departments on employee.DepartmentId equals department.Id
                          select new EmployeeOffDayDto
                          {
                              Id = employee.Id,
                              Name = employee.Name + " " + employee.LastName,
                              BirthDate = employee.BirthDate,
                              IdentityNumber = employee.IdentitiyNumber,
                              DepartmentName = department.Name,

                          };

                return res.ToList();
            }
        }

        public OffDay GetOffDayByEmployee(int employeeId, DateTime date)
        {
            using (var context = new EmployeeDbContext()) 
            {
               var res = context.Offdays.Where(o=>o.EmployeeId == employeeId && o.Date== date).FirstOrDefault();
                return res;
            }
        }

        public PayrollParameter GetPayrollParameter()
        {
            using(var context = new EmployeeDbContext())
            {
                return context.PayrollParameters.FirstOrDefault();
            }
        }
    }
}
