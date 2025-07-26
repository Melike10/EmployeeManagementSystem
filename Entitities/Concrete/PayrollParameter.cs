using Core.DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PayrollParameter:IEntity
    {
        public int Id { get; set; }
        public decimal NetMinimumWage { get; set; }
        public decimal BrutMinimumWage { get; set; }
        public decimal Parameter1 { get; set; }
        public decimal Parameter2 { get; set; }
    }
}
