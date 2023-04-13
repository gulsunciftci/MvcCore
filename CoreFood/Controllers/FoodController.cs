﻿using CoreFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreFood.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList("Category"));
        }
    }
}