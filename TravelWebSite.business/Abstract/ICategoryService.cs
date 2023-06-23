using TravelWebSite.entity;

namespace TravelWebSite.business.Abstract
{
    public interface ICategoryService
    {
        List<Category>GetAll();
         Category GetById(int id);
         public void Create(Category entity);
         public void Update(Category entity);
         public void Delete(Category entity);        
    }
}