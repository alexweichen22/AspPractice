namespace HomeInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeItems",
                c => new
                    {
                        HomeItemId = c.Int(nullable: false, identity: true),
                        Model = c.String(maxLength: 100),
                        SerialNumber = c.String(maxLength: 100),
                        LocationId = c.Int(nullable: false),
                        PurchaseInfoId = c.Int(nullable: false),
                        Description = c.String(maxLength: 255),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.HomeItemId)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseInfoes", t => t.PurchaseInfoId, cascadeDelete: true)
                .Index(t => t.LocationId)
                .Index(t => t.PurchaseInfoId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.PurchaseInfoes",
                c => new
                    {
                        PurchaseInfoId = c.Int(nullable: false, identity: true),
                        When = c.DateTime(),
                        Where = c.String(maxLength: 255),
                        Warranty = c.String(maxLength: 255),
                        Price = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PurchaseInfoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeItems", "PurchaseInfoId", "dbo.PurchaseInfoes");
            DropForeignKey("dbo.HomeItems", "LocationId", "dbo.Locations");
            DropIndex("dbo.HomeItems", new[] { "PurchaseInfoId" });
            DropIndex("dbo.HomeItems", new[] { "LocationId" });
            DropTable("dbo.PurchaseInfoes");
            DropTable("dbo.Locations");
            DropTable("dbo.HomeItems");
        }
    }
}
