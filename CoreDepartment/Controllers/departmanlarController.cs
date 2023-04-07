using Microsoft.AspNetCore.Mvc;

namespace CoreDepartment.Controllers
{
    public class departmanlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
