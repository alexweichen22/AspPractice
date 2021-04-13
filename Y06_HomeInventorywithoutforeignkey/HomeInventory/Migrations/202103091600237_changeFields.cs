namespace HomeInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HomeItems", "Description", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.PurchaseInfoes", "Price", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PurchaseInfoes", "Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.HomeItems", "Description", c => c.String(maxLength: 255));
        }
    }
}
