using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Travel_Blog.Models;

namespace Travel_Blog.Controllers
{
    public class PeoplesController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        public IActionResult Index()
        {
         return View(db.Peoples.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisPerson = db.Peoples.FirstOrDefault(peoples => peoples.PeopleId == id);
            return View(thisPerson);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (People people)
        {
            db.Peoples.Add(people);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
