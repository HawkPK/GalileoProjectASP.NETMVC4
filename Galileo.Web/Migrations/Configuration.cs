namespace Galileo.Web.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Galileo.Web.Infrastructure.DepartmentDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Galileo.Web.Infrastructure.DepartmentDB context)
        {
            context.Departments.AddOrUpdate(d => d.Name,
                   new Department() { Name = "Programmer" },
                   new Department() { Name = "Accountant" },
                   new Department() { Name = "Logistic" },
                   new Department() { Name = "Administrator" }
                   );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
