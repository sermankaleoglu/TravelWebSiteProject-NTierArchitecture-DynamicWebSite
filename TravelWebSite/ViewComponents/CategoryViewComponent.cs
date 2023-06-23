using Microsoft.AspNetCore.Mvc;
using TravelWebSite.business.Abstract;

namespace TravelProject.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            this._categoryService=categoryService;
        }
       public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View (_categoryService.GetAll());
        }        
    }
}