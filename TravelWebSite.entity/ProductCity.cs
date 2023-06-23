namespace TravelWebSite.entity
{
    public class ProductCity
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }   

        public int CityId { get; set; }       
        public City? City { get; set; }
    }
}