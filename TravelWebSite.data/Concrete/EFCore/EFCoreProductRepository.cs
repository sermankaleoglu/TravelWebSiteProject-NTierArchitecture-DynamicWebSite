using Microsoft.EntityFrameworkCore;
using TravelWebSite.data.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.data.Concrete.EFCore
{
    public class EFCoreProductRepository : EFCoreGenericRepository<Product, TravelWebSiteContext>, IProductRepository
    {
        public List<Product> GetProductsByCategory(int id)
        {
            using(var context=new TravelWebSiteContext())
            {
                var products=context.Products.AsQueryable();
                if(id != 0)
                {
                    products=products.Include(i=>i.ProductCategory)
                                     .ThenInclude(i=>i.Category)
                                     .Where(i=>i.ProductCategory.Any(a=>a.Category.CategoryId==id));
                }
                return products.ToList();
            }                }

        public List<Product> GetProductsBySearch(string search)
        {
            using(var context = new TravelWebSiteContext())
            {
                var products = context.Products.AsQueryable();
               
                products=products
                            .Include(i=>i.ProductCategory)
                            .ThenInclude(i=>i.Category)
                            .Where(i=>i.ProductCategory.Any(a=>
                                a.Product.Name.ToUpper().Contains(search.ToUpper()) 
                                    || a.Product.Description.ToUpper().Contains(search.ToUpper())
                                    || a.Category.Name.ToUpper().Contains(search.ToUpper())
                                ));
                return products.ToList();
                
            }
        }
    }
}