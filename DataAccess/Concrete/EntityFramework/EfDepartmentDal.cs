using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Dtos;
using Entitities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department,EmployeeDbContext>,IDepartmentDal
    {
        public EfDepartmentDal(EmployeeDbContext context) : base(context)
        {
        }

        //private readonly EmployeeDbContext _context;
        //private readonly Department _department;

        //public EfDepartmentDal(EmployeeDbContext context, Department department)
        //{
        //    _context = context;
        //    _department = department;
        //}
        //public void Add(Department dept)
        //{

        //        _context.Departments.Add(dept);
        //        _context.SaveChanges();

        //}

        public bool CheckDepartmentUses(int deptId)
        {
            using (var _context = new EmployeeDbContext())
            {
                var res = _context.Employees.Where(e => e.DepartmentId == deptId);
                return res.Count() > 0 ? false : true;
            }
        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            using (var _context = new EmployeeDbContext()) {
                var res = from department in _context.Departments
                          select new DepartmentDto
                          {
                              Id = department.Id,
                              Name = department.Name,
                              EmployeeCount = _context.Employees.Where(x => x.DepartmentId == department.Id && x.Status== "Çalışıyor").Count()
                          };

                return res.ToList();
            }
        }

        //public void Delete(Department dept)
        //{
        //    _context.Departments.Remove(dept);
        //    _context.SaveChanges();
        //}

        //public Department Get(int id)
        //{
        //    var res = _context.Departments.Where(x => x.Id == id).FirstOrDefault();
        //    return res;
        //}

        //public List<Department> GetList()
        //{
        //    using(var context = new EmployeeDbContext())
        //    {
        //        var res = context.Departments.ToList();
        //        return res;
        //    }
        //}

        public void StatusChange(Department dept)
        {
            using (var _context = new EmployeeDbContext())
            {
                dept.Status = !dept.Status;
                _context.Departments.Update(dept);
                _context.SaveChanges();
            }
        }

        //public void Update(Department dept)
        //{
        //    _context.Departments.Update(dept);
        //    _context.SaveChanges();
        //}
    }
}
