namespace OdeToFood.Migrations
{
	using OdeToFood.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
			context.Restaurants.AddOrUpdate(r => r.Name,
				new Restaurant { Name = "Stone Burgers", City = "AAAAA", Country = "The Republic of Ree" },
				new Restaurant { Name = "Spine'n'Dine", City = "Bb Town", Country = "Aa Land" },
				new Restaurant
				{
					Name = "Smoochdirt",
					City = "Crafter's Union",
					Country = "Miwecwaftia",
					Reviews = 
						new List<RestaurantReview>{
						new RestaurantReview { Rating = 9, Body = "Great Food!", ReviewerName = "Scott" }
					}
				});
        }
    }
}
