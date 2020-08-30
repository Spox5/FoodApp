using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers
{
    public class SearchMealController : Controller
    {
        private readonly IngredientRepository ingredientRepository;
        private readonly MealRepository mealRepository;

        public SearchMealController(IngredientRepository ingredientRepository, MealRepository mealRepository)
        {
            this.ingredientRepository = ingredientRepository;
            this.mealRepository = mealRepository;
        }

        [HttpGet]
        public IActionResult Index(int userId)
        {
            var ingredients = ingredientRepository.GetByUserId(userId);

            return View(ingredients);
        }

        [HttpPost]
        public List<Meal> Search([FromBody]SearchMealPostViewModel searchMealPostViewModel)
        {
            return mealRepository.GetByIngredients(searchMealPostViewModel.IngredientIds);
        }
    }
}
