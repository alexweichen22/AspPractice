namespace XHomeInventory.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<XHomeInventory.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XHomeInventory.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Items.AddOrUpdate(
          new Item() { SerialNo = "UI-X-S100012", Location = "salon", Description = "Lamp", Where = "IKEA", Model = "Brick", When = DateTime.Now, Warranty = 1, Price = 60},
          new Item() { SerialNo = "UI-X-S20033", Location = "family room", Description = "Sofa", Where = "IKEA", Model = "Brick", When = DateTime.Now, Warranty = 2, Price = 1000},
          new Item() { SerialNo = "UI-X-S20077", Location = "dining room", Description = "Plant", Where = "IKEA", Model = "Brick", When = DateTime.Now, Warranty = 2, Price = 20 }
          );
            context.SaveChanges();

        }
    }
}
