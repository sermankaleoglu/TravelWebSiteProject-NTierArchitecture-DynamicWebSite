using Microsoft.AspNetCore.Mvc;
using TravelWebSite.business.Abstract;

namespace TravelProject.ViewComponents
{
    public class CityViewComponent:ViewComponent
    {
        private ICityService _cityService;
        public CityViewComponent(ICityService cityService)
        {
            this._cityService=cityService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cityService.GetAll());
        } 
    }
}