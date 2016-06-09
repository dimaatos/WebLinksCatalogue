using System;
using System.Collections.Generic;
using WebLinksCatalogue.Domain.Abstract;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.Repositories
{
    public class LinkRepository : IRepository<Link>
    {
        private readonly EfDbContext _context;

        public LinkRepository(EfDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Link> GetAll() =>
            _context.Links;

        public Link Get(int id) =>
            _context.Links.Find(id);

        public void Add(Link item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Links.Add(item);
        }

        public void Remove(int id)
        {
            Link link = Get(id);

            if (link == null)
            {
                throw new NullReferenceException($"There is no Link with id: {id}");
            }

            _context.Links.Remove(link);
        }
    }
}
