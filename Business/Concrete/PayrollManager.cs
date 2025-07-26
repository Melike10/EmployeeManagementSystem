using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PayrollManager : IPayrollService
    {
        private readonly IPayrollDal _payrollDal;

        public PayrollManager(IPayrollDal payrollDal)
        {
            _payrollDal = payrollDal;
        }

        public bool Add(int month , int year)
        {
            var payrollList= _payrollDal.GetList().Where(p=>p.Year == year && p.Mounth == month).ToList();
            if (payrollList.Count > 0)
            {
                if (MessageBox.Show("Seçilen ay ve yıla ait oluşturulmuş bordro sistemden silinip tekrar oluşturulacaktır. Onaylıyor musunuz?", "Bordro Mevcut!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var payroll in payrollList)
                    {
                        _payrollDal.Delete(payroll);
                    }
                }
                else return false;
            }
            var parameter = _payrollDal.GetPayrollParameter();
            var employees = _payrollDal.GetEmployees();
            var workday = 0;

            DateTime date1 = new DateTime(year, month, 1);
            DateTime date2 = date1.AddMonths(1).AddDays(-1);

            foreach (var employee in employees)
            {
                int offDays = _payrollDal.GetEmployeeOffDay(employee.Id, month, year);

                if (employee.StartingDate > date2)
                    continue; // Ay bitiminden sonra başlamışsa işlem yapma

                DateTime workStart = employee.StartingDate > date1 ? employee.StartingDate : date1;
                DateTime workEnd = date2;

                if (employee.Status == "İşten Ayrıldı" && employee.EndingDate >= date1)
                {
                    // İşten çıkış tarihi ay sonundan küçükse
                    if (employee.EndingDate <= date2)
                        workEnd = (DateTime)employee.EndingDate;
                }

                TimeSpan ts = workEnd - workStart;
                workday = ts.Days + 1;

                if (workday >= date2.Day)
                    workday = 30;

                if (workday > 0)
                {
                    decimal cumulative = 0;

                    for (int m = 1; m < month; m++)
                    {
                        var p = _payrollDal.Get(g =>
                            g.EmployeeId == employee.Id &&
                            g.Mounth == m &&
                            g.Year == year);

                        if (p != null)
                            cumulative += p.IncomeTaxAssesment;
                    }
                    workday -= offDays;
                    Payroll payroll = new Payroll()
                    {
                        
                        EmployeeId = employee.Id,
                        NetPay = (employee.Salary / 30) * workday,
                        WorkDay = workday,
                        Mounth = month,
                        Year = year,
                        GrossPay = (((employee.Salary / 30) *workday)-((parameter.Parameter1/30)*workday))*parameter.Parameter2,
                        InsuarancePremiumEmployeeShare = ((((employee.Salary / 30) * workday) - ((parameter.Parameter1 / 30) * workday)) * parameter.Parameter2) * 15 / 100,
                        IncomeTaxAssesment = ((((employee.Salary / 30) * workday) - ((parameter.Parameter1 / 30) * workday)) * parameter.Parameter2),
                        CumilativeTaxAssesment= cumulative+ ((((employee.Salary / 30) * workday) - ((parameter.Parameter1 / 30) * workday)) * parameter.Parameter2),


                    };
                    _payrollDal.Add(payroll);

                }

            }
           
            MessageBox.Show("Bordro oluşturulmuştur.","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void Delete(Payroll payroll)
        {
            _payrollDal.Delete(payroll);
        }

        public List<PayrollListDto> GetPayrollList()
        {
            return _payrollDal.GetPayrolList();
        }

        public List<PayrollDto> GetPayrollsOfEmployee()
        {
            return _payrollDal.GetPayrollsOfEmployee();
        }
    }
}
