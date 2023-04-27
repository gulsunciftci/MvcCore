using CoreFood.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.Controllers
{
    public class ChartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }
        public List<Chart> ProList()
        {
            List<Chart> charts = new List<Chart>();
            charts.Add(new Chart()
            {
                proname="Computer",
                stock=150

            });
            charts.Add(new Chart()
            {
                proname = "Lcd",
                stock = 75

            });
            charts.Add(new Chart()
            {
                proname = "Usb Dist",
                stock = 220

            });

            return charts;
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<Chart2> FoodList()
        {
            List<Chart2> cs2 = new List<Chart2>();
            using(var c=new Context())
            {
                cs2 = c.Foods.Select(x => new Chart2
                {
                    foodname = x.Name,
                    stock=x.Stock
                }).ToList();

            }

            return cs2;

        }
        public IActionResult Statistics()
        {
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            var deger3 = c.Foods.Where(x=>x.CategoryID== c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(x => x.CategoryName == "Vegetable").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d4 = deger4;

            var deger6 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(x => x.CategoryName == "Legumes").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            var deger5 = c.Foods.Sum(x => x.Stock);
            ViewBag.d5 = deger5;

            var deger7 = c.Foods.OrderByDescending(x => x.Stock).Select(x => x.Name).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.Foods.OrderBy(x => x.Stock).Select(x => x.Name).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;

            var deger10 = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            var deger10p = c.Foods.Where(y => y.CategoryID == deger10).Sum(x => x.Stock);
            ViewBag.d10 = deger10p;

            var deger11 = c.Categories.Where(x => x.CategoryName == "Vegetable").Select(y => y.CategoryID).FirstOrDefault();
            var deger11p = c.Foods.Where(y => y.CategoryID == deger11).Sum(x => x.Stock);
            ViewBag.d11 = deger11p;

            var deger12 = c.Foods.OrderByDescending(x => x.Price).Select(x => x.Name).FirstOrDefault();
            ViewBag.d12 = deger12;

            return View();
        }
    }
}
