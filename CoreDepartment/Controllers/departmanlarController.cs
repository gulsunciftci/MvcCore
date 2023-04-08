using Microsoft.AspNetCore.Mvc;
using CoreDepartment.Models;
namespace CoreDepartment.Controllers
{
    public class departmanlarController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departments d)
        {
            return View();
        }
    }
}
