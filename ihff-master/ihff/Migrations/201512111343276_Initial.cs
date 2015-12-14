namespace ihff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Start = c.Time(nullable: false, precision: 7),
                        End = c.Time(nullable: false, precision: 7),
                        RoomId = c.Int(nullable: false),
                        Movie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id)
                .Index(t => t.ActivityId)
                .Index(t => t.LocationId)
                .Index(t => t.RoomId)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LocationId = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: false)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Speakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RestaurantId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Activity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .Index(t => t.Activity_Id);
            
            CreateTable(
                "dbo.WishlistItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Wishlist_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.Wishlists", t => t.Wishlist_Id)
                .Index(t => t.ActivityId)
                .Index(t => t.Wishlist_Id);
            
            CreateTable(
                "dbo.Wishlists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Runtime = c.Int(nullable: false),
                        Trailer = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Specials",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SpeakerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Id)
                .ForeignKey("dbo.Speakers", t => t.SpeakerId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.SpeakerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Specials", "SpeakerId", "dbo.Speakers");
            DropForeignKey("dbo.Specials", "Id", "dbo.Activities");
            DropForeignKey("dbo.Restaurants", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Restaurants", "Id", "dbo.Activities");
            DropForeignKey("dbo.Movies", "Id", "dbo.Activities");
            DropForeignKey("dbo.WishlistItems", "Wishlist_Id", "dbo.Wishlists");
            DropForeignKey("dbo.WishlistItems", "ActivityId", "dbo.Activities");
            DropForeignKey("dbo.Tickets", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.Reservations", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Shows", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Shows", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Shows", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Shows", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Specials", new[] { "SpeakerId" });
            DropIndex("dbo.Specials", new[] { "Id" });
            DropIndex("dbo.Restaurants", new[] { "LocationId" });
            DropIndex("dbo.Restaurants", new[] { "Id" });
            DropIndex("dbo.Movies", new[] { "Id" });
            DropIndex("dbo.WishlistItems", new[] { "Wishlist_Id" });
            DropIndex("dbo.WishlistItems", new[] { "ActivityId" });
            DropIndex("dbo.Tickets", new[] { "Activity_Id" });
            DropIndex("dbo.Reservations", new[] { "RestaurantId" });
            DropIndex("dbo.Rooms", new[] { "LocationId" });
            DropIndex("dbo.Shows", new[] { "Movie_Id" });
            DropIndex("dbo.Shows", new[] { "RoomId" });
            DropIndex("dbo.Shows", new[] { "LocationId" });
            DropIndex("dbo.Shows", new[] { "ActivityId" });
            DropTable("dbo.Specials");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Movies");
            DropTable("dbo.Wishlists");
            DropTable("dbo.WishlistItems");
            DropTable("dbo.Tickets");
            DropTable("dbo.Reservations");
            DropTable("dbo.Speakers");
            DropTable("dbo.Rooms");
            DropTable("dbo.Locations");
            DropTable("dbo.Shows");
            DropTable("dbo.Activities");
            DropTable("dbo.Accounts");
        }
    }
}
