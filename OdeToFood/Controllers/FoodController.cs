
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class FoodController : Controller
    {
        // GET: Seafood
        public ActionResult Search(string culture, string food)
        {
			return Content("Order the best " + culture + " " + food + " now!");
        }
    }
}