using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPayrollService
    {
        bool Add(int month, int year);
        void Delete(Payroll payroll);   
        List<PayrollDto> GetPayrollsOfEmployee();
        List<PayrollListDto> GetPayrollList();
    }
}
