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
    public class EfPayrollDal : EfEntityRepositoryBase<Payroll, EmployeeDbContext>, IPayrollDal
    {
        public EfPayrollDal(EmployeeDbContext context) : base(context)
        {
        }

        public int GetEmployeeOffDay(int employeeId, int month, int year)
        {
            using (var context = new EmployeeDbContext())
            {
                DateTime startDate = new DateTime(year, month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                return context.Offdays
                              .Count(o => o.EmployeeId == employeeId && o.Date >= startDate && o.Date <= endDate);
            }
        }


        public List<Employee> GetEmployees()
        {
            using (var context = new EmployeeDbContext())
            {
              

                var employees = context.Employees                    
                    .OrderBy(e => e.Name)
                    .ToList();

                return employees;
            }
        }

        public List<PayrollListDto> GetPayrolList()
        {
            // ay ve yıllara göre gruplama yapıldı bordroda
            using (var context = new EmployeeDbContext())
            {
                var groupedPayrolls = context.Payrolls
                    .GroupBy(p => new { p.Mounth, p.Year })
                    .Select(g => new PayrollListDto
                    {
                        Month = g.Key.Mounth,
                        Year = g.Key.Year,
                        EmployeeCount = g.Count(),
                        TotalNetPay = g.Sum(p => p.NetPay)
                    })
                    .OrderBy(p => p.Year).ThenBy(p => p.Month)
                    .ToList();

                return groupedPayrolls;
            }

            }

        


        public PayrollParameter GetPayrollParameter()
        {
            using(var context = new EmployeeDbContext())
            {
                var res = context.PayrollParameters.FirstOrDefault();
                return res;
            }
        }

        public List<PayrollDto> GetPayrollsOfEmployee()
        {
            using (var context = new EmployeeDbContext()) 
            {
                var res = from payroll in context.Payrolls
                          join employee in context.Employees on payroll.EmployeeId equals employee.Id
                          select new PayrollDto
                          {
                              Id= payroll.Id,
                              EmployeeId=payroll.EmployeeId,
                              FullName = employee.Name+" "+employee.LastName,
                              IdentityNumber = employee.IdentitiyNumber,
                              WorkDay = payroll.WorkDay,
                              GrossPay = payroll.GrossPay,
                              NetPay = payroll.NetPay,
                              Mounth = payroll.Mounth,
                              Year = payroll.Year,
                              IncomeTaxAssesment = payroll.IncomeTaxAssesment,
                              InsuarancePremiumEmployeeShare = payroll.InsuarancePremiumEmployeeShare,
                              CumilativeTaxAssesment= payroll.CumilativeTaxAssesment

                              

                          };
                return res.OrderBy(o=>o.FullName).ToList();
            }
        }
    }
}
