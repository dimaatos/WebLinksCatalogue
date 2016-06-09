using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.EF
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() : base("WebLinksCatalogue")
        {

        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
