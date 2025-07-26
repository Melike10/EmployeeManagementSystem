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
    public interface IPayrollDal:IEntityRepository<Payroll>
    {
        List<PayrollDto> GetPayrollsOfEmployee();
        List<Employee> GetEmployees();
        List<PayrollListDto> GetPayrolList();
        PayrollParameter GetPayrollParameter();

        int GetEmployeeOffDay(int employeeId, int month, int year);
    }
}
