using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal:IEntityRepository<Employee>
    {
        //void Add(Employee employee);
        //List<Employee> GetAll();
        List<EmployeeDto> GetEmployeeList();
        List<EmployeeOffDayDto> GetEmployeeOffDayList();
        OffDay GetOffDayByEmployee(int employeeId,DateTime date);
        PayrollParameter GetPayrollParameter();
       
    }
}
