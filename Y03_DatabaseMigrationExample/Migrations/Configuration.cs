namespace DatabaseMigrationExample.Migrations
{
    using DatabaseMigrationExample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseMigrationExample.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseMigrationExample.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
                new Customer() { Name = "Reza", Age = 12 },
                new Customer() { Name = "MO", Age = 11 },
                new Customer() { Name = "Donal", Age = 13 });

            context.Inventories.AddOrUpdate(
            new Inventory() { Name = "inv1", Capacity = 1200 },
            new Inventory() { Name = "inv2", Capacity = 1100 },
            new Inventory() { Name = "inv3", Capacity = 1300 });
            context.SaveChanges();
        }
    }
}
