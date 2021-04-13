using HomeInventory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeInventory.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<HomeItem> HomeItems { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PurchaseInfo> PurchaseInfoes { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}