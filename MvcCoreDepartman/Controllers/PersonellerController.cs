using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCoreDepartman.Models;

namespace MvcCoreDepartman.Controllers
{
    public class PersonellerController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.Include(x=>x.Birim).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAd,
                                                 Value = x.BirimID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;

            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            var per = c.Birims.Where(x => x.BirimID == p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelSil(int id)
        {
            var per = c.Personels.Find(id);
            c.Personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonelGetir(int id)
        {
            List<SelectListItem> degerler = (from x in c.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAd,
                                                 Value = x.BirimID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;

            var per = c.Personels.Find(id);
            return View("PersonelGetir", per);
        }
        public IActionResult PersonelGüncelle(Personel d)
        {
            var per = c.Personels.Find(d.PersonelID);
            per.Ad = d.Ad;
            per.Soyad = d.Soyad;
            per.Sehir = d.Sehir;
            per.BirimID = d.Birim.BirimID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
