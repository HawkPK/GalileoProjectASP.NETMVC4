namespace Galileo.Web.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Galileo.Web.Models.VideoDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Galileo.Web.Models.VideoDB context)
        {
            context.Videos.AddOrUpdate(m => m.Name,
                new Video() { Name = "kkk", Length = 1000 },
                new Video() { Name = "ppp", Length = 2000 });

            context.SaveChanges();
        }
    }
}
