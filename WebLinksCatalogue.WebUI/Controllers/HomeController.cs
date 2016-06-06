using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLinksCatalogue.WebUI.Models;

namespace WebLinksCatalogue.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new List<WebLinkModel> { new WebLinkModel() { Name="1" } });
        }
    }
}