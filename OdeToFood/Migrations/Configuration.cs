namespace OdeToFood.Migrations
{
	using FizzWare.NBuilder;
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
			var restaurants = Builder<Restaurant>.CreateListOfSize(60)
				.All()
					.With(c => c.Name = Faker.Company.Name())
					.With(c => c.City = Faker.Address.City())
					.With(c => c.Country = Faker.Country.Name())
				.Build();

			context.Restaurants.AddOrUpdate(c => c.Id, restaurants.ToArray());

		}
    }
}
