using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcCoreDepartman.Models;

namespace MvcCoreDepartman.Controllers
{
    public class PersonellerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x=>x.Birim).ToList();
            return View(degerler);
        }
    }
}
