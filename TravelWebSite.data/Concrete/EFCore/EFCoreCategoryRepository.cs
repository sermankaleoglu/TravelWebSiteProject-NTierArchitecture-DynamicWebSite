using Microsoft.Data.Sqlite;
using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.data.Concrete.EFCore
{
    public class EFCoreCategoryRepository : EFCoreGenericRepository<Category, TravelWebSiteContext>, ICategoryRepository
    {
        
    }
}