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
    }
}
