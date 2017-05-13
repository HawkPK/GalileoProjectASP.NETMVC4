using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galileo.Domain
{
    public class Employee
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? HireDate { get; set; }

    }
}
