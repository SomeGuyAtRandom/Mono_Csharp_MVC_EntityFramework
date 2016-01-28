using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using web.ContextDbs;
using web.Models;

namespace web.Controllers
{
    public class PersonController : Controller
    {
		private PeopleContext db;

		public PersonController()
		{
			this.db = new PeopleContext();
		}
        public ActionResult Index()
        {

			List<Person> people;
			people = this.db.People.ToList();
			return View(people);
        }

		public ActionResult TestAddtion()
		{
			
			Person person = new Person () {
				FirstName = "Some",
				LastName ="Guy"
			};
			db.People.Add (person);
			db.SaveChanges();

			return RedirectToAction("Index","Home"); 
		} 
    }
}
