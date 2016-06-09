using System;
using System.Collections.Generic;
using WebLinksCatalogue.Domain.Abstract;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly EfDbContext _context;

        public CommentRepository(EfDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
