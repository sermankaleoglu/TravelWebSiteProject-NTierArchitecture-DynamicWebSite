using TravelWebSite.entity;

namespace TravelWebSite.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetProductsByCategory(int id);
        List<Product> GetProductsBySearch(string search);

    }
}