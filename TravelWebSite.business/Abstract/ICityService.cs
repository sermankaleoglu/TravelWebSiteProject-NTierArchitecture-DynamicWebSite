using TravelWebSite.entity;

namespace TravelWebSite.business.Abstract
{
    public interface ICityService
    {
         List<City>GetAll();
         City GetById(int id);
         public void Create(City entity);
         public void Update(City entity);
         public void Delete(City entity);        
    }
}