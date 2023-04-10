using Microsoft.AspNetCore.Mvc;
using CoreDepartment.Models;
namespace CoreDepartment.Controllers
{
    public class departmanlarController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departments.ToList();
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
            c.departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanSil(int id)
        {
            var dep = c.departments.Find(id);
            c.departments.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.departments.Find(id);
            return View("DepartmanGetir",depart);
        }
        public IActionResult DepartmanGüncelle(departments d)
        {
            var dep = c.departments.Find(d.Id);
            dep.departmanAd = d.departmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
