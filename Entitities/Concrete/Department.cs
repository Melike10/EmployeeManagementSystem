﻿using Core.DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitities.Concrete
{
    public class Department:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
