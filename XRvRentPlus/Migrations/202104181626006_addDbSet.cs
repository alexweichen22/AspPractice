namespace XRvRentPlus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateBooked = c.DateTime(nullable: false),
                        DateRentStart = c.DateTime(nullable: false),
                        DateRentEnd = c.DateTime(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Rv_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rvs", t => t.Rv_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Rv_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Rv_Id", "dbo.Rvs");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Rv_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
