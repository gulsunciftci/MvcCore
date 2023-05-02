using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.TList();
            return View(foodList);
        }
    }
}
