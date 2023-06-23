namespace TravelWebSite.entity
{
    public class City
    {
        public int CityId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public List<ProductCity>? ProductCity { get; set; }
        
    }
}