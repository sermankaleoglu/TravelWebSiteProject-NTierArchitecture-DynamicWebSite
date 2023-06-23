using TravelWebSite.business.Abstract;
using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
       private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}