using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SearchMealController : Controller
    {
        private readonly IngredientRepository ingredientRepository;
        private readonly MealRepository mealRepository;
        private readonly IngredientCategoryRepository ingredientCategoryRepository;

        public SearchMealController(IngredientRepository ingredientRepository, MealRepository mealRepository, IngredientCategoryRepository ingredientCategoryRepository)
        {
            this.ingredientRepository = ingredientRepository;
            this.mealRepository = mealRepository;
            this.ingredientCategoryRepository = ingredientCategoryRepository;
        }

        [HttpGet]
        public IActionResult Index(int userId)
        {
            var ingredients = ingredientRepository.GetByUserIdAndAllGeneric(userId);
            var ingredientCategories = ingredientCategoryRepository.GetAll();

            var searchViewModel = new SearchMealViewModel
            {
                Ingredients = ingredients,
                IngredientCategories = ingredientCategories
            };

            return View(searchViewModel);
        }

        [HttpPost]
        public List<Meal> Search([FromBody] SearchMealPostViewModel searchMealPostViewModel)
        {
            return mealRepository.GetByIngredients(searchMealPostViewModel.IngredientIds);
        }
    }
}