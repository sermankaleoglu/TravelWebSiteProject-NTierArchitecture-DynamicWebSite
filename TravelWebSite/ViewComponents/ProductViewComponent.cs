using Microsoft.AspNetCore.Mvc;
using TravelWebSite.business.Abstract;

namespace TravelProject.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private IProductService _productService;
        public ProductViewComponent(IProductService productService)
        {
            this._productService=productService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_productService.GetAll());
        }        
    }
}