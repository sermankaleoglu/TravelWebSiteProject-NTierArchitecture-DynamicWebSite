using Microsoft.AspNetCore.Mvc;
using TravelProject.Models;
using TravelWebSite.business.Abstract;

namespace TravelProject.Controllers
{
    public class HomeController:Controller
    {
        private ICityService _cityService;
        public HomeController(ICityService cityService)
        {
            this._cityService=cityService;
        }
        public IActionResult index(int id)
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
    }
}