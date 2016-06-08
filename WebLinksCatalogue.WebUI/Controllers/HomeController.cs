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
            EfDbContext db = new EfDbContext();
            
            return View(db.Links/*new List<Link> { new Link() { Title="1" } }*/);
        }
    }
}