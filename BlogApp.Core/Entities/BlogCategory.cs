using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public class BlogCategory : BaseEntitty
    {
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public Blog Blog { get; set; }
        public Category Category { get; set; }
    }
}
