using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galileo.Domain
{
    public interface IDepartmentSource
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
        void Save();

    }
}
