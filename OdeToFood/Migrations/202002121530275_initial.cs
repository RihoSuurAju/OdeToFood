﻿namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    City = c.String(),
                    Country = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.RestaurantReviews",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    City = c.String(),
                    Country = c.String(),
                    Rating = c.Int(nullable: false),
                    Body = c.String(),
                    ReviewerName = c.String(),
                    RestaurantID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.RestaurantReviews", "RestaurantID", "dbo.Restaurants");
            DropIndex("dbo.RestaurantReviews", new[] { "RestaurantID" });
            DropTable("dbo.RestaurantReviews");
            DropTable("dbo.Restaurants");
        }
    }
}