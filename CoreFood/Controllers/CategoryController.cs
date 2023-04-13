using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            return View(categoryRepository.TList());
        }
    }
}
