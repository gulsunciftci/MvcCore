using Microsoft.AspNetCore.Mvc;

namespace CoreFood.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
