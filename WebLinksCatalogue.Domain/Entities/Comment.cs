using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLinksCatalogue.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Link Link { get; set; }
        public int LinkId { get; set; }
    }
}
