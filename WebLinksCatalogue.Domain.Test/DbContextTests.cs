using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.Test
{
    [TestClass]
    public class DbContextTests
    {
        [TestMethod]
        public void TestGet()
        {
            EfDbContext db = new EfDbContext();


            db.Links.Add(new Entities.Link() { Title = "1", Url = "23" });
            db.SaveChanges();

            Link link = db.Links.First();

            Assert.AreEqual(1, db.Links.Count());
            Assert.AreEqual(1, link.Title);
            Assert.AreEqual(23, link.Url);
        }
    }
}
