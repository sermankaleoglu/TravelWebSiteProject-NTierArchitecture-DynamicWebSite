namespace TravelProject.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int CityId{get; set;}        
    }
}