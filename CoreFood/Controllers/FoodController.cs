using CoreFood.Models;
using CoreFood.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreFood.Controllers
{
    
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context c = new Context();
        
        
        public IActionResult Index(int page=1)
        {
            
            return View(foodRepository.TList("Category").ToPagedList(page,3));
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
        
        public IActionResult DeleteFood(int id)
        {
           
            foodRepository.TDelete(new Food { FoodID=id});
            return RedirectToAction("Index");
        }
        
        public IActionResult GetFood(int id)
        {
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryID.ToString()
                                           }).ToList();

            ViewBag.v1 = values;

            var x = foodRepository.TGet(id);
            Food f = new Food()
            {
                FoodID=x.FoodID,
                Name=x.Name,
                Price=x.Price,
                Stock=x.Stock,
                CategoryID=x.CategoryID,
                Description=x.Description,
                ImageURL=x.ImageURL
            };

            return View(f);
        }
        [HttpPost]
        
        public IActionResult UpdateFood(Food p)
        {
            var x = foodRepository.TGet(p.FoodID);
            x.Name = p.Name;
            x.Price = p.Price;
            x.Stock = p.Stock;
            x.CategoryID = p.CategoryID;
            x.Description = p.Description;
            x.ImageURL = p.ImageURL;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
