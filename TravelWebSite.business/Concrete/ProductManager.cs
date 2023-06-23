using TravelWebSite.business.Abstract;
using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository=productRepository;
        }
        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProductsByCategory(int id)
        {
            return _productRepository.GetProductsByCategory((int)id);
        }

        public List<Product> GetProductsBySearch(string search)
        {
            return _productRepository.GetProductsBySearch(search);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}