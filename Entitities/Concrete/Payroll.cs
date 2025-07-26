using Core.DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payroll:IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Mounth {  get; set; }
        public int Year { get; set; }
        public int WorkDay { get; set; }
        public decimal GrossPay { get; set; }
        public decimal NetPay { get; set; }
        public decimal InsuarancePremiumEmployeeShare  { get; set; }// sigorta prim işçi payı
        public decimal IncomeTaxAssesment { get; set; } // gelir vergisi matrağı
        public decimal CumilativeTaxAssesment { get; set; }// kümülatif matrak

    }
}
