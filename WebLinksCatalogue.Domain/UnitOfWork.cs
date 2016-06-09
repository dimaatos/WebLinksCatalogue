using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinksCatalogue.Domain.Abstract;
using WebLinksCatalogue.Domain.EF;
using WebLinksCatalogue.Domain.Entities;
using WebLinksCatalogue.Domain.Repositories;

namespace WebLinksCatalogue.Domain
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed;
        private readonly EfDbContext _context;
        private IRepository<Link> _linkRepository;
        private IRepository<Category> _categoryRepository;
        private IRepository<Comment> _commentRepository;

        public UnitOfWork(IRepository<Category> categoryRepository, IRepository<Comment> commentRepository)
        {
            _categoryRepository = categoryRepository;
            _commentRepository = commentRepository;
            _context = new EfDbContext();
        }

        public IRepository<Link> LinkRepository =>
            _linkRepository ?? (_linkRepository = new LinkRepository(_context));

        public IRepository<Category> CategoryRepository =>
            _categoryRepository ?? (_categoryRepository = new CategoryRepository(_context));

        public IRepository<Comment> CommentRepository =>
            _commentRepository ?? (_commentRepository = new CommentRepository(_context));

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
