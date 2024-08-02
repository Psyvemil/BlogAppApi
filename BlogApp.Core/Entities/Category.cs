using System.Data.SqlTypes;

namespace BlogApp.Core.Entities
{
    public class Category : BaseEntitty 
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }
    }
}
