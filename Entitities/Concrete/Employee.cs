using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;


namespace Entitities.Concrete
{
    public class Employee:IEntity
    {
       public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string? ReasonOfLeaving { get; set; }
        public string IdentitiyNumber { get; set; }
        public string Status { get; set; }

    }
}
