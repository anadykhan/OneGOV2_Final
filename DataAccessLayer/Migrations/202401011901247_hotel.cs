namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hotel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserBookings", "BookBy", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserBookings", "BookBy");
            CreateIndex("dbo.UserBookings", "HotelID");
            CreateIndex("dbo.UserBookings", "RoomID");
            AddForeignKey("dbo.UserBookings", "HotelID", "dbo.Hotels", "HotelID", cascadeDelete: true);
            AddForeignKey("dbo.UserBookings", "RoomID", "dbo.Rooms", "RoomID", cascadeDelete: true);
            AddForeignKey("dbo.UserBookings", "BookBy", "dbo.Users", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBookings", "BookBy", "dbo.Users");
            DropForeignKey("dbo.UserBookings", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.UserBookings", "HotelID", "dbo.Hotels");
            DropIndex("dbo.UserBookings", new[] { "RoomID" });
            DropIndex("dbo.UserBookings", new[] { "HotelID" });
            DropIndex("dbo.UserBookings", new[] { "BookBy" });
            AlterColumn("dbo.UserBookings", "BookBy", c => c.String());
        }
    }
}
