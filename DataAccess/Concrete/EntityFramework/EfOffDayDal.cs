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
    public class EfOffDayDal : EfEntityRepositoryBase<OffDay, EmployeeDbContext>, IOffDayDal
    {
        public EfOffDayDal(EmployeeDbContext context) : base(context)
        {
        }

        public Employee GetEmployee(int employeeId)
        {
            using (var context = new EmployeeDbContext())
            {
                var res = context.Employees.Find(employeeId);
                return res;
            }
        }

        public List<OffDayDto> GetEmployeeOffDays()
        {
            using (var context = new EmployeeDbContext())
            {
                var res = from offDay in context.Offdays
                          join employee in context.Employees on offDay.EmployeeId equals employee.Id
                          select new OffDayDto
                          {
                              Id= offDay.Id,
                              EmployeeId = offDay.EmployeeId,
                              Date = offDay.Date,
                              Name = employee.Name+" "+employee.LastName,
                          };

                return res.OrderByDescending(x => x.Date).ToList();
            }
        }
    }
}
