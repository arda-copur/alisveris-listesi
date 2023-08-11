using Microsoft.AspNetCore.Mvc;

namespace AlisverisListesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
