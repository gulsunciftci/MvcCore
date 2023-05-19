using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.List(x=>x.CategoryID==id);
            return View(foodList);
        }
    }
}
