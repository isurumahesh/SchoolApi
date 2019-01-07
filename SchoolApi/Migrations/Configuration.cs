namespace SchoolApi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolApi.Entities.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolApi.Entities.StudentContext context)
        {
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

            if (!context.Students.Any())
            {
                context.Students.AddRange(new List<Student>() { new Student() {FirstName="Isuru",LastName="Mahesh",Age=28,Address="Nittambuwa" },
                new Student() { FirstName = "Sara", LastName = "Nirmani", Age = 62, Address = "Colombo 07" } });
                context.SaveChanges();
            }
            
        }
    }
}
