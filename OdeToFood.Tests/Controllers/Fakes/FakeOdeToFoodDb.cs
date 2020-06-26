using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Tests.Controllers.Fakes
{
	/*class FakeOdeToFoodDb : OdeToFoodDb
	{
		public Dictionary<Type, object> Sets = new Dictionary<Type, object>();
		public List<object> Added = new List<object>();
		public List<object> Updated = new List<object>();
		public List<object> Removed = new List<object>();
		public bool Saved = false;

		public void Add<T>(T entity) where T : class
		{
			Added.Add(entity);
		}
		public void AddSet<T>(IQueryable<T> objects)
		{
			Sets.Add(typeof(T), objects);
		}
		public void Dispose() {  }
		public void Remove<T>(T entity) where T : class
		{
			Removed.Add(entity);
		}
		public void SaveChanges(T Entity)
		{
			Updated.Add(entity);
		}
	}*/
}
