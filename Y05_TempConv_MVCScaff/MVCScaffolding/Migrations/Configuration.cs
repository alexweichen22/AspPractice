namespace MVCScaffolding.Migrations
{
    using MVCScaffolding.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCScaffolding.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCScaffolding.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Students.AddOrUpdate(new Student() { Name = "A", EnrollmentDate = DateTime.Now },
                new Student() { Name = "B", EnrollmentDate = DateTime.Now },
                new Student() { Name = "C", EnrollmentDate = DateTime.Now });
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
