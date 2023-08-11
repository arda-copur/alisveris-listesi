using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlisverisListesi.Controllers
{
    public class UserListController : Controller
    {
        UserListNameManager nm = new UserListNameManager(new EfUserListNameDal());
        public IActionResult Index(int id)
        {
            var values = nm.UserProductListName(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddUserList()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserList(UserProductListName userProductListName)
        {

            nm.TAdd(userProductListName);
            return RedirectToAction("Index", "UserList", new { id = userProductListName.UserId });

        }
    }
}
