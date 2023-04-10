using Microsoft.AspNetCore.Mvc;

namespace MvcCoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
