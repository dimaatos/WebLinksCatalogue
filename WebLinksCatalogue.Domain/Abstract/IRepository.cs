using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLinksCatalogue.Domain.Abstract
{
    public interface IRepository<out T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
