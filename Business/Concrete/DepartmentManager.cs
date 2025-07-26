using Business.Abstract;
using DataAccess.Abstract;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns;
using Entities.Dtos;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmenDal)
        {
            _departmentDal = departmenDal;
        }

        public bool Add(Department department)
        {
            var validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            {
                _departmentDal.Add(department);
                MessageBox.Show("Bölüm başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void Delete(Department department)
        {
            var res = _departmentDal.CheckDepartmentUses(department.Id);
            if (!res)
            {
                MessageBox.Show("Bu departmana ait personel kayıtları olduğu için bölüm silinemez","Hata!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _departmentDal.Delete(department);
        }

        public Department Get(int id)
        {
            return _departmentDal.Get(g => g.Id== id);
        }

        public int GetDepartmentId(string name)
        {
            //bölüm ismine göre bölüm ıd getirildi.
            return _departmentDal.GetList().Where(d=>d.Name == name).Select(s=>s.Id).FirstOrDefault();
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            return _departmentDal.GetListEmployeeCount();
        }

        public bool StatusChange(Department department)
        {
            _departmentDal.StatusChange(department);
            MessageBox.Show("Durum başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool Update(Department department)
        {
            var validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            {
                _departmentDal.Update(department);
                MessageBox.Show("Bölüm başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
