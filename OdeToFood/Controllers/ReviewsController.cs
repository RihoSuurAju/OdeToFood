using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
		OdeToFoodDb _db = new OdeToFoodDb();
		[ChildActionOnly]
		public ActionResult BestReview()
		{
			var best = from r in _reviews
					   orderby r.Rating descending
					   select r;
			return PartialView("_Review", best.First());
		}

		public ActionResult LatestReviews()
		{
			var model = from r in _reviews
						orderby r.Country
						select r;
			return View(model);
		}
		// GET: Reviews
		public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
		{
			var restaurant = _db.Restaurants.Find(restaurantId);
			if (restaurant != null)
			{
				return View(restaurant);
			}
			return HttpNotFound();
		}
		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}

		[HttpGet]
		public ActionResult Create(int RestaurantId)
		{
			Restaurant restaurant = _db.Restaurants.Find(RestaurantId);
			ViewBag.Name = restaurant.Name;
            ViewBag.resId = restaurant.Id;
			return View();
		}

		[HttpPost]
		public ActionResult Create(RestaurantReview review)
		{
			if (ModelState.IsValid)
			{
				_db.Reviews.Add(review);
				_db.SaveChanges();
				return RedirectToAction("Index", new { id = review.RestaurantId });
			}
			return View();
		}
		// GET: Reviews/Details/5

		[HttpGet]
		public ActionResult Edit(int id)
		{
			var model = _db.Reviews.Find(id);
			return View(model);
		}

		[HttpPost]
		public ActionResult Edit([Bind(Exclude = "ReviewerName")]EditReviewViewModel review)
		{
			if (ModelState.IsValid)
			{
				var editable_review = _db.Reviews.Find(review.Id);
				editable_review.Body = review.Body;
				editable_review.Rating = review.Rating;
				_db.Entry(editable_review).State = EntityState.Modified;
				_db.SaveChanges();
				return RedirectToAction("Index", new { id = editable_review.RestaurantId });
			}
			return View(review);
		}
		static List<RestaurantReview> _reviews = new List<RestaurantReview>
		{
			new RestaurantReview
			{
				Id = 4,
				Name = "Cinnamon Club",
				City = "London",
				Country = "UK",
				Rating = 10
			},

			new RestaurantReview
			{
				Id = 5,
				Name = "Marrakesh",
				City = "D.C",
				Country = "USA",
				Rating = 9
			},

			new RestaurantReview
			{
				Id = 6,
				Name = "The House of Elliot",
				City = "Ghent",
				Country = "Belgium",
				Rating = 7
			}
		};
	}
}
