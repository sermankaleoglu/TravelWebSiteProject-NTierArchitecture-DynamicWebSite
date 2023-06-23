using TravelWebSite.entity;

namespace TravelWebSite.business.Abstract
{
    public interface IProductService
    {
         List<Product>GetAll();
         Product GetById(int id);
         List<Product>GetProductsByCategory(int id);
        List<Product>GetProductsBySearch(string search);
         public void Create(Product entity);
         public void Update(Product entity);
         public void Delete(Product entity);        
    }
}