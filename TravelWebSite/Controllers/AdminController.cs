using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelProject.Models;
using TravelWebSite.business.Abstract;
using TravelWebSite.entity;

namespace TravelWebSite.Controllers
{
    public class AdminController:Controller
    {
        private IProductService _productService;
        public AdminController(IProductService productService)
        {
            this._productService=productService;
        }
        public IActionResult ProductList()
        {
            return View( new ProductListViewModel()
            {
                Product=_productService.GetAll()
            });            
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity=new Product()
            {
                Name=model.Name,
                Price=model.Price,
                Description=model.Description,
                ImageUrl=model.ImageUrl
            };           
            _productService.Create(entity);
            
            var msg= new AlertMessage()
            {
                Message= $"{entity.Name} isimli ürün eklendi.",
                AlertType="success"            
            };
            TempData["message"]=JsonConvert.SerializeObject(msg);            
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var entity=_productService.GetById((int)id);
            if(entity==null)
            {
                return NotFound();
            }
            var model=new ProductModel()
            {
                ProductId=entity.ProductId,
                Name=entity.Name,
                Price=entity.Price,
                Description=entity.Description,
                ImageUrl=entity.ImageUrl
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductModel model)
        { 
            var entity=_productService.GetById(model.ProductId);
            if(entity==null)
            {
                return NotFound();
            }
            entity.Name=model.Name;
            entity.Price=model.Price;
            entity.ImageUrl=model.ImageUrl;
            entity.Description=model.Description;
            _productService.Update(entity);
            var msg= new AlertMessage()
            {
                Message= $"{entity.Name} isimli ürün güncellendi.",
                AlertType="success"            
            };
            TempData["message"]=JsonConvert.SerializeObject(msg);;
            return RedirectToAction("ProductList");

        } 

        public IActionResult DeleteProduct(int ProductId)
        {
            var entity=_productService.GetById(ProductId);
            if(entity!=null)
            {
                _productService.Delete(entity);
            }
            
            var msg= new AlertMessage()
            {
                Message= $"{entity.Name} isimli ürün silindi..",
                AlertType="danger"            
            };
            TempData["message"]=JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }
         
    }
}