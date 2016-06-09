using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinksCatalogue.Domain.EF.Config;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.EF
{
    public class EfDbContext : DbContext
    {
        public DbSet<Link> Links { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EfDbContext() : base("WebLinksCatalogue")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LinkEntityConfig());
            modelBuilder.Configurations.Add(new CommentEntityConfig());
            modelBuilder.Configurations.Add(new CategoryEntityConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
