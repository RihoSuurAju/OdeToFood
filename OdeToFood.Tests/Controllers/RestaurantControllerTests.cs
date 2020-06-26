using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Tests.Controllers
{
	/*[TestClass]
	class RestaurantControllerTests
	{
		private OdeToFoodDb db = new OdeToFoodDb();

		IOdeToFoodDb _db;
		public RestuarantsController()
		{
			db = new OdeToFoodDb();
		}
		public RestaurantsController(IOdeToFoodDb db)
		{
			db = db;
		}

		[TestMethod]
		public void Create_Saves_Restaurant_when_Valid()
		{
			var db = new FakeOdeToFoodDb();
			var controller = new RestaurantsController(db);

			controller.Create(new Models.Restaurant());

			Assert.AreEqual(1, db.Added.Count);
			Assert.AreEqual(true, db.Saved);
		}
		[TestMethod]
		public void Create_Does_Not_Save_Restaurant_When_Invalid()
		{
			var db = new FakeOdeToFoodDb();
			var controller = new RestaurantsController(db);
			controller.ModelState.AddModelError("", "Invalid");
		}
	}*/
}
