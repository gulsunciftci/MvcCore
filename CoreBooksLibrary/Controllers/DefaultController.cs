using Microsoft.AspNetCore.Mvc;

namespace CoreBooksLibrary.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
