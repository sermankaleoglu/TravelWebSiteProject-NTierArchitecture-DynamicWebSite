namespace TravelWebSite.entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

    

        public List<ProductCategory>? ProductCategory { get; set; }
        
    }
}