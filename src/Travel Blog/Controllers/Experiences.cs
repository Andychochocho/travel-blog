using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Travel_Blog.Models;

namespace Travel_Blog.Controllers
{
    public class ExperiencesController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Experiences.ToList());
        }
    }
}
