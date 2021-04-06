namespace X02c_DatabaseMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<X02c_DatabaseMigration.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(X02c_DatabaseMigration.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
                new Models.Customer() { Name="Stephanie", Age=35},
                new Models.Customer() { Name="Elon Musk", Age=45}
                );

            context.SaveChanges();
        }
    }
}
