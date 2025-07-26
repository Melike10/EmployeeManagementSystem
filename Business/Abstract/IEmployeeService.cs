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
    public interface IEmployeeService
    {
        bool Add(Employee employee);
        bool Update(Employee employee);
        void UpdateList(Employee employee);
        void QuitJob(Employee employee);
        void ReHired(Employee employee);
        void Delete(Employee employee);
        List<Employee> GetAll();
        List<EmployeeDto> GetEmployeeDtos();
        Employee Get(int id);
        List<EmployeeOffDayDto> GetEmployeeOffDayList();
        OffDay GetOffDayByEmployee(int employeeId, DateTime date);
        PayrollParameter GetPayrollParameter();
    }
}
