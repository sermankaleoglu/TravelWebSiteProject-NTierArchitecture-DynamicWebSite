using Microsoft.AspNetCore.Mvc;
using TravelProject.Models;
using TravelWebSite.business.Abstract;
using TravelWebSite.entity;

namespace TravelProject.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService=productService;
        }
        public IActionResult list(int? id,string q)
        {
            if(id==1)
            {
                 var products=new ProductListViewModel()
                {
                    Product=_productService.GetAll()
                };
                return View(products);
            }
            else if(id!=null)
            {
                var products=new ProductListViewModel()
                {
                    Product=_productService.GetProductsByCategory((int)id)
                };
                return View(products);
            }
            if(!string.IsNullOrEmpty(q))
            {
                var products=new ProductListViewModel()
                {
                    Product=_productService.GetProductsBySearch(q)
                };
                return View(products);
            }
            else
            {
                var productViewModel=new ProductListViewModel()
                {
                    Product=_productService.GetAll()
                };
                return View(productViewModel);
            }
            
        }
        public IActionResult detail(int id)
        {
            if(id==null)
            {
                return NotFound();
            }
            Product product =_productService.GetById((int)id);
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}