using Core.DataAccess;
using Entities.Dtos;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal:IEntityRepository<Department>
    {
       
        void StatusChange(Department dept);
        //Department Get(int id);
        //List<Department> GetList();
        bool CheckDepartmentUses(int deptId);
        List<DepartmentDto> GetListEmployeeCount();
    }
}
