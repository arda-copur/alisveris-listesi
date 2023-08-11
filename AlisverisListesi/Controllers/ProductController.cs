using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace AlisverisListesi.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = pm.GetList();
            ViewBag.Categories = cm.GetList().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            return View(values);    
        }
        [HttpGet]
        public IActionResult AddProduct( )
        {
            

            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {

            pm.TAdd(product);
            return RedirectToAction("Index", "Product");
        }

    }
}
