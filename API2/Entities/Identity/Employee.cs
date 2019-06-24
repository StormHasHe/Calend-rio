using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Identity
{
    public class Employee
    {
        public Employee()
        {
        }

        public virtual int intEmployeeID { get; set; }
        public virtual string txtLogin { get; set; }
        public virtual string txtPassword { get; set; }
    }
}
