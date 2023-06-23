using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.data.Concrete.EFCore
{
    public class EFCoreCityRepository: EFCoreGenericRepository<City, TravelWebSiteContext>, ICityRepository
    {
        
    }
}