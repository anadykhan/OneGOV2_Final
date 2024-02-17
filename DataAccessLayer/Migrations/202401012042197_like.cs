namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class like : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartID);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        LikeID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 128),
                        BlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LikeID)
                .ForeignKey("dbo.Blogs", t => t.BlogID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserName)
                .Index(t => t.UserName)
                .Index(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Likes", "UserName", "dbo.Users");
            DropForeignKey("dbo.Likes", "BlogID", "dbo.Blogs");
            DropIndex("dbo.Likes", new[] { "BlogID" });
            DropIndex("dbo.Likes", new[] { "UserName" });
            DropTable("dbo.Likes");
            DropTable("dbo.Carts");
        }
    }
}
