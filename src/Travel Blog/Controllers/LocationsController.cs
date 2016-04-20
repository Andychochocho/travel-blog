using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Travel_Blog.Models;

namespace Travel_Blog.Controllers
{
    public class LocationsController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            thisLocation.Experiences = db.Experiences.Where(experience => experience.LocationId == id).ToList();
            return View(thisLocation);
        }
    }
}
