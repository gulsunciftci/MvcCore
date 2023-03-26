using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;
using System.Diagnostics;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "Merhaba bugün hava çok soğuk";
        }
        public IActionResult Index5 ()
        {
            var Kitaplar = new List<Kitap>()
            {
                new Kitap(){ID=1,KitapAd="80 Günde Devri Alem",Yazar="Jules Verne"},
                new Kitap(){ID=2,KitapAd="Bilinmeyen bir Kadının Mektubu",Yazar="Zweig"},
                 new Kitap(){ID=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickes"}
            };
            return View(Kitaplar);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1="Merhaba Core Dersleri Devam Ediyor";

            return View();
        }
    }
}