using CoreFood.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.Controllers
{
    public class ChartController : Controller
    {
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
    }
}
