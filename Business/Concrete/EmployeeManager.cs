using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public bool Add(Employee employee)
        {
            bool validation = ValidationTool.Validate(new EmployeeValidator(),employee);
            if (validation)
            {
                var res = _employeeDal.GetList().Where(x=> x.IdentitiyNumber == employee.IdentitiyNumber).FirstOrDefault();

                if (res != null) 
                {
                    MessageBox.Show("Yazdığınız TC kimlik numarasına sahip kişi sistemde zaten mevcuttur.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }

                var resSalary = GetPayrollParameter();
                if (resSalary.NetMinimumWage > employee.Salary)
                {
                    MessageBox.Show("Asgari ücretten az maaş girilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _employeeDal.Add(employee);
                MessageBox.Show("Personel başarılı şekilde kaydedilmiştir.");
                return true;
            }
            return false;
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public Employee Get(int id)
        {
            return _employeeDal.Get(e=>e.Id== id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<EmployeeDto> GetEmployeeDtos()
        {
            return _employeeDal.GetEmployeeList();
        }

        public List<EmployeeOffDayDto> GetEmployeeOffDayList()
        {
            return _employeeDal.GetEmployeeOffDayList();
        }

        public OffDay GetOffDayByEmployee(int employeeId, DateTime date)
        {
            return _employeeDal.GetOffDayByEmployee(employeeId, date);

        }

        public PayrollParameter GetPayrollParameter()
        {
           return  _employeeDal.GetPayrollParameter();
        }

        public void QuitJob(Employee employee)
        {
            
            _employeeDal.Update(employee);
            MessageBox.Show("Personelin işten çıkış işlemi başarıyla yapılmıştır.","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReHired(Employee employee)
        {
            _employeeDal.Update(employee);
            MessageBox.Show("Personelin tekrar işe alım işlemi başarıyla yapılmıştır.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Update(Employee employee)
        {
            bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
            if (validation)
            {
                var findOldId = _employeeDal.Get(x=>x.Id==employee.Id);
                if (findOldId.IdentitiyNumber != employee.IdentitiyNumber)
                {
                    var res = _employeeDal.GetList().Where(x => x.IdentitiyNumber == employee.IdentitiyNumber).FirstOrDefault();

                    if (res != null)
                    {
                        MessageBox.Show("Yazdığınız TC kimlik numarasına sahip kişi sistemde zaten mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    var resSalary = GetPayrollParameter();
                    if (resSalary.NetMinimumWage > employee.Salary)
                    {
                        MessageBox.Show("Asgari ücretten az maaş girilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                _employeeDal.Update(employee);
                MessageBox.Show("Personel başarılı şekilde güncellenmiştir.");
                return true;
            }
            return false;
        }

        public void UpdateList(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
