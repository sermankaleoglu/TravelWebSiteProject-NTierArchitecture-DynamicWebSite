using TravelWebSite.business.Abstract;
using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;
        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository=cityRepository;
        }
        public void Create(City entity)
        {
            _cityRepository.Create(entity);
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();        
        }
        public City GetById(int id)
        {
            return _cityRepository.GetById((int)id);

        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}