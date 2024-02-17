namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class room : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "HotelNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "HotelID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "HotelID", c => c.Int(nullable: false));
            DropColumn("dbo.Rooms", "HotelNumber");
        }
    }
}
