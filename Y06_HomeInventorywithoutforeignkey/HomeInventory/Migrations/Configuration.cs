namespace HomeInventory.Migrations
{
    using HomeInventory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeInventory.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeInventory.Infrastructure.ApplicationDbContext context)
        {
            context.Locations.AddOrUpdate(l => l.Name,
               new Location()
               {
                   Name = "Home Office",
                   LocationId = 1
               },
               new Location()
               {
                   Name = "Family Room",
                   LocationId = 2

               },
               new Location()
               {
                   Name = "Living Room",
                   LocationId = 3

               },
               new Location()
               {
                   Name = "Kitchen",
                   LocationId = 4

               },
               new Location()
               {
                   Name = "Master Bedroom",
                   LocationId = 5

               },
               new Location()
               {
                   Name = "Bedroom Two",
                   LocationId = 6

               },
               new Location()
               {
                   Name = "Bedroom Three",
                   LocationId = 7

               },
               new Location()
               {
                   Name = "Bathrooms",
                   LocationId = 8

               },
               new Location()
               {
                   Name = "Garage",
                   LocationId = 9

               },
               new Location()
               {
                   Name = "Attic",
                   LocationId = 10

               },
               new Location()
               {
                   Name = "Basement",
                   LocationId = 11

               },
               new Location()
               {
                   Name = "Other",
                   LocationId = 12

               }
          );
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
