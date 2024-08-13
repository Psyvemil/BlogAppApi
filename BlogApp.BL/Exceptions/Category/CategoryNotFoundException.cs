using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Exceptions.Category
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException() : base("Category is not found ") { }
        public CategoryNotFoundException(string message) : base(message) { }
    }
}
