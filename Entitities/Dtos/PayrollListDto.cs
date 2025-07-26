using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PayrollListDto
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int EmployeeCount { get; set; }
        public decimal TotalNetPay { get; set; }
    }
}
