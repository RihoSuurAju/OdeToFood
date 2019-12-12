using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		OdeToFoodDb _db = new OdeToFoodDb();

		public ActionResult Index()
		{
			var model = _db.Restaurants.ToList();

			return View(model);
		}

		public ActionResult About()
		{
			var Model = new AboutModel();
			Model.Name = "Riho-Martin";
			Model.Location = "Tallin, Estonia";
			Model.Age = 17;

			return View(Model);
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		protected override void Dispose(bool disposing)
		{
			if (_db != null) base.Dispose(disposing);
		}
	}
}