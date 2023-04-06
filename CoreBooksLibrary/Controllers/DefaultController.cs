using CoreBooksLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBooksLibrary.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1,KitapAd="Satranç",Yazar="Zweig"},
                new Kitaplar(){ID=2,KitapAd="Dr Ox'un Deneyi",Yazar="Jules Verne"},
                new Kitaplar(){ID=3,KitapAd="Delifişek",Yazar="Vasconceulos"}
            };
            return View(ktp);
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
