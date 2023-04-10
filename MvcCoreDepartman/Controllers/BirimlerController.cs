using Microsoft.AspNetCore.Mvc;
using MvcCoreDepartman.Models;

namespace MvcCoreDepartman.Controllers
{
    public class BirimlerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim d)
        {
            c.Birims.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimSil(int id)
        {
            var dep = c.Birims.Find(id);
            c.Birims.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimGetir(int id)
        {
            var depart = c.Birims.Find(id);
            return View("BirimGetir", depart);
        }
        public IActionResult BirimGüncelle(Birim d)
        {
            var dep = c.Birims.Find(d.BirimID);
            dep.BirimAd = d.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
