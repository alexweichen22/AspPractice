namespace X02b_DataBinding.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<X02b_DataBinding.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(X02b_DataBinding.Models.ApplicationDbContext context)
        {

            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            /*
                context.Products.AddOrUpdate(
                    new Models.Product(){ Name = "Night Table Lamp", Description="Ikea, Black, 15 Walts, LED"},
                    new Models.Product(){ Name = "King Size Bed", Description = "Hard Oak, Brown, Texture"}
                    );
                context.SaveChanges();
            */
        }
    }
}
