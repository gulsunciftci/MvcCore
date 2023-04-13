using CoreFood.Models;
using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context c = new Context();
        public IActionResult Index()
        {
            return View(foodRepository.TList("Category"));
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.CategoryName,
                                               Value=x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(Food p )
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
