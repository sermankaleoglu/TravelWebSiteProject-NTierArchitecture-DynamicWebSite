using TravelWebSite.entity;

namespace TravelProject.Models
{
    public class ProductListViewModel
    {
        public List<Product> Product { get; set; }
        public List<Category> Category { get; set; }
        public List<string> CategoryAdmin {get;set;}
    }
}