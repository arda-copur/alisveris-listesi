using Business.Concrete;
using DataAccess;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlisverisListesi.Controllers
{
    public class UserProductListController : Controller
    {
        UserProductListManager um = new UserProductListManager(new EfUserProductListDal());
        UserListNameManager lm = new UserListNameManager(new EfUserListNameDal());
        ProductManager pm = new ProductManager(new EfProductDal());

        public IActionResult Index(int id)
        {
            var values = um.UserProductList(id);
            
            return View(values);
        }
        [HttpGet]
        public IActionResult AddUserProductList()
        {
            List<SelectListItem> userproductlistnamevalues = (from x in lm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.ListeAdi,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            List<SelectListItem> productlistnamevalues = (from x in pm.GetList()
                                                              select new SelectListItem
                                                              {
                                                                  Text = x.ÜrünAdı,
                                                                  Value = x.Id.ToString()
                                                              }).ToList();
            ViewBag.userproductlistnamevalues = userproductlistnamevalues;
            ViewBag.productlistnamevalues = productlistnamevalues;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserProductList(UserProductList userProductList)
        {

            um.TAdd(userProductList);
            return RedirectToAction("Index", "UserProductList", new { id = userProductList.UserProductListNameId });

        }
    }
}
