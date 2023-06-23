using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.data.Concrete.SQL
{
    public class SQLProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsBySearch(string search)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}