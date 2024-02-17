namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false),
                    AuthorName = c.String(nullable: false),
                    Description = c.String(nullable: false),
                    Type = c.String(nullable: false),
                    Blogby = c.String(maxLength: 128),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);
               
                
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CommentedBy = c.String(maxLength: 128),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CommentedBy)
                .Index(t => t.CommentedBy)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriID = c.Int(nullable: false, identity: true),
                        CategoriName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        EventDate = c.DateTime(nullable: false),
                        Location = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        OrganizerID = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelID = c.Int(nullable: false, identity: true),
                        HotelName = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HotelID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderBy = c.String(maxLength: 128),
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.OrderBy)
                .Index(t => t.OrderBy)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        SubTittle = c.String(nullable: false),
                        Rating = c.Double(nullable: false),
                        Price = c.Int(nullable: false),
                        CategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoriId, cascadeDelete: true)
                .Index(t => t.CategoriId);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductDescription = c.String(nullable: false),
                        ProductRating = c.Int(nullable: false),
                        ReviewedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        RoomType = c.String(),
                        AvailabilityStatus = c.String(),
                        ImageURL = c.String(),
                        HotelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        UserId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserBookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        BookingStatus = c.String(),
                        BookBy = c.String(),
                        HotelID = c.Int(nullable: false),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderBy = c.String(maxLength: 128),
                        Price = c.Int(nullable: false),
                        Decision = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.OrderBy)
                .Index(t => t.OrderBy);
            
            CreateTable(
                "dbo.UserReviews",
                c => new
                    {
                        UserReviewID = c.Int(nullable: false, identity: true),
                        ReviewDescription = c.String(nullable: false),
                        ReviewedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserReviewID)
                .ForeignKey("dbo.Users", t => t.ReviewedBy)
                .Index(t => t.ReviewedBy);
            
            CreateTable(
                "dbo.WishProducts",
                c => new
                    {
                        WishlistID = c.Int(nullable: false, identity: true),
                        WishProductName = c.String(nullable: false),
                        WishProductDescription = c.String(nullable: false),
                        AskedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.WishlistID)
                .ForeignKey("dbo.Users", t => t.AskedBy)
                .Index(t => t.AskedBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishProducts", "AskedBy", "dbo.Users");
            DropForeignKey("dbo.UserReviews", "ReviewedBy", "dbo.Users");
            DropForeignKey("dbo.UserOrders", "OrderBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "OrderBy", "dbo.Users");
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoriId", "dbo.Categories");
            DropForeignKey("dbo.Blogs", "Blogby", "dbo.Users");
            DropForeignKey("dbo.Comments", "CommentedBy", "dbo.Users");
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropIndex("dbo.WishProducts", new[] { "AskedBy" });
            DropIndex("dbo.UserReviews", new[] { "ReviewedBy" });
            DropIndex("dbo.UserOrders", new[] { "OrderBy" });
            DropIndex("dbo.Products", new[] { "CategoriId" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "OrderBy" });
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropIndex("dbo.Comments", new[] { "CommentedBy" });
            DropIndex("dbo.Blogs", new[] { "Blogby" });
            DropTable("dbo.WishProducts");
            DropTable("dbo.UserReviews");
            DropTable("dbo.UserOrders");
            DropTable("dbo.UserBookings");
            DropTable("dbo.Tokens");
            DropTable("dbo.Rooms");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Hotels");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
