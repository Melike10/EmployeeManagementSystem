using Entities.Concrete;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOffDayService
    {
        bool Add(int employeeId,string date1,string date2);
        bool Update(OffDay offDay);
        bool Delete(OffDay offDay);
        List<OffDayDto> GetEmployeeOffDays();
        OffDay GetEmployeeOffDayByDate(int id, DateTime date);
        Employee GetEmployee(int employeeId);
        OffDay GetById(int id);
    }
}
