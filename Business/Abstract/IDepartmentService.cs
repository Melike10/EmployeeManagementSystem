using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        bool Add(Department department);
        bool Update(Department department);
        void Delete(Department department);
        Department Get(int id);
        bool StatusChange(Department department);
        int GetDepartmentId(string name);
        List<Department> GetList();
        List<DepartmentDto> GetListEmployeeCount();
    }
}
