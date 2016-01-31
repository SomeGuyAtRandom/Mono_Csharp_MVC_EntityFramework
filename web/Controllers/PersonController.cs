using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using web.ContextDbs;
using web.Models;
using System.Data.Entity;

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

		public ActionResult Details(int? Id)
		{
			if (Id == null)
			{
				return RedirectToAction("Index");
			}
			Person person = this.db.People.Find(Id);

			if (person == null)
			{
				return HttpNotFound();
			}
			return View (person);
		}

		[HttpGet]
		[ActionName("Edit")]
		public ActionResult Edit(int? Id)
		{
			if (Id == null)
			{
				return RedirectToAction("Index");
			}
			Person person = this.db.People.Find(Id);

			if (person == null)
			{
				return HttpNotFound();
			}
			return View (person);
		}

		[HttpPost]
		[ActionName("Edit")]
		public ActionResult Edit(Person p)
		{

			if (ModelState.IsValid) 
			{ 
				db.Entry(p).State = EntityState.Modified; 
				db.SaveChanges(); 
				return RedirectToAction("Index"); 
			} 

			return View ("Details", p);
		}

		[HttpGet]
		[ActionName("Create")]
		public ActionResult Create()
		{
			
			return View ();

		}

		[HttpPost]
		[ActionName("Create")]
		public ActionResult Create([Bind (Include = "FirstName,LastName,BirthDate")]Person p)
		{
			ModelState["BirthDate"].Errors.Clear();
			if (ModelState.IsValid) 
			{ 
				db.Entry(p).State = EntityState.Modified;
				db.People.Add(p); 
				db.SaveChanges(); 
				return RedirectToAction("Index"); 
			} 
			return View ("Create", p);
		}

    }
}
