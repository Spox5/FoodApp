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
            var meal = ingredientRepository.GetByUserId(userId);

            var ingredients = new List<Ingredient>
            {
                new Ingredient
                {
                    Id = 4,
                },
                new Ingredient
                {
                    Id = 4,
                },
                new Ingredient
                {
                    Id = 4,
                },
            };
            var meals = mealRepository.GetByIngredients(ingredients);


            //var viewModel = new SearchMealViewModel();
            return View(userId);
        }
    }
}
