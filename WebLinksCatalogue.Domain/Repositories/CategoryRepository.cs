using System;
using System.Collections.Generic;
using WebLinksCatalogue.Domain.Abstract;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly EfDbContext _context;

        public CategoryRepository(EfDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
