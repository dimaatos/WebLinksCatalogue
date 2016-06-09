using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinksCatalogue.Domain.Entities;

namespace WebLinksCatalogue.Domain.EF.Config
{
    public class CommentEntityConfig : EntityTypeConfiguration<Comment>
    {
        public CommentEntityConfig()
        {
            HasRequired(comment => comment.Link).WithMany(link => link.Comments);
        }
    }
}
