namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
		public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

		protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants.AddOrUpdate(x => x.Id,
            new Restaurant() { Id = 1, Name = "Mineshop", City = "Minecraftia", Country = "CoolLand" },
            new Restaurant() { Id = 2, Name = "Luxurious Delicacy", City = "Ouioui", Country = "France" }
            );
            context.Reviews.AddOrUpdate(x => x.Id,
            new RestaurantReview() { Id = 1, Rating = 8, Body = "A nice night out.", ReviewerName = "Joe", RestaurantId = 1 }
            );
        }
    }
}
