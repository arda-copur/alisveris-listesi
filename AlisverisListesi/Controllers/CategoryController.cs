using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlisverisListesi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
  

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {

            cm.TAdd(category);
            return RedirectToAction("Index", "Category");
        }

    }
}
