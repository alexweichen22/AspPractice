namespace MVCBlogAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Content", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "Title", c => c.Int(nullable: false));
            AlterColumn("dbo.Comments", "Content", c => c.Int(nullable: false));
        }
    }
}
