using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;
using WebLinksCatalogue.WebUI.Models;

namespace WebLinksCatalogue.WebUI.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Links));
        }

        public ActionResult Links()
        {
            EfDbContext db = new EfDbContext();

            return View(db.Links/*new List<Link> { new Link() { Title="1" } }*/);
        }

        public ActionResult Categories()
        {
            EfDbContext db = new EfDbContext();

            return View(db.Categories/*new List<Link> { new Link() { Title="1" } }*/);
        }

        public ActionResult CreateLink()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLink(Link newLink)
        {
            EfDbContext db = new EfDbContext();
            db.Links.Add(newLink);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}