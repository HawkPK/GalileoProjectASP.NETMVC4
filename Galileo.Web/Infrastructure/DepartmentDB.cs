using Galileo.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galileo.Web.Infrastructure
{
    class DepartmentDB : DbContext, IDepartmentSource
    {
        public DepartmentDB() : base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public void Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentSource.Employees
        {
            get
            {
                return Employees;
            }
        }

        IQueryable<Department> IDepartmentSource.Departments
        {
            get
            {
                return Departments;
            }
        }

        public System.Data.Entity.DbSet<Galileo.Web.Models.CreateEmployeeViewModel> CreateEmployeeViewModels { get; set; }
    }
}
