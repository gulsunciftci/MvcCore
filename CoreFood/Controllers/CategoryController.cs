using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreFood.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace CoreFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        
        public IActionResult Index(string p,int page=1)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x => x.CategoryName == p).ToPagedList(page, 3));
            }
            
            return View(categoryRepository.TList().ToPagedList(page, 3));
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
            
        }
     
        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.TGet(id);
            Category ct = new Category()
            {
                CategoryID=x.CategoryID,
                CategoryName=x.CategoryName,
                CategoryDescription=x.CategoryDescription
            };

            return View(ct);
        }
        [HttpPost]
        
        public IActionResult CategoryUpdate(Category p)
        {
            var x = categoryRepository.TGet(p.CategoryID);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        
        public IActionResult CategoryDelete(int id)
        {
            var x = categoryRepository.TGet(id);
            x.Status = false;
            categoryRepository.TUpdate(x);

            return RedirectToAction("Index");
        }
    }
}
