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
            c.Departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departmanlars.Find(id);
            c.Departmanlars.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Departmanlars.Find(id);
            return View("DepartmanGetir",depart);
        }
        public IActionResult DepartmanGüncelle(departments d)
        {
            var dep = c.Departmanlars.Find(d.Id);
            dep.departmanAd = d.departmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
