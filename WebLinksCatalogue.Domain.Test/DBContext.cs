using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebLinksCatalogue.Domain.EF;

namespace WebLinksCatalogue.Domain.Test
{
    [TestClass]
    public class DBContext
    {
        [TestMethod]
        public void TestGet()
        {
            EfDbContext db = new EfDbContext();
            db.Links.Add(new Entities.Link() { Title = "1", Url = "23" });
            db.SaveChanges();
        }
    }
}
