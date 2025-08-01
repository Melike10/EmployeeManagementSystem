﻿using Core.DataAccess;
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
    public interface IOffDayDal:IEntityRepository<OffDay>
    {
        List<OffDayDto> GetEmployeeOffDays();
        Employee GetEmployee(int employeeId);
        
    }
}
