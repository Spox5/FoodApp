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
    public class ManageMealsController : Controller
    {
        private readonly MealRepository mealRepository;
        private readonly IngredientRepository ingredientRepository;
        private readonly IngredientCategoryRepository ingredientCategoryRepository;


        public ManageMealsController(MealRepository mealRepository, IngredientRepository ingredientRepository, IngredientCategoryRepository ingredientCategoryRepository)
        {
            this.mealRepository = mealRepository;
            this.ingredientRepository = ingredientRepository;
            this.ingredientCategoryRepository = ingredientCategoryRepository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var userID = int.Parse(HttpContext.User.Identity.Name);
            var mealsIngredients = new ManageMealViewModel();
            mealsIngredients.Meals = mealRepository.GetByUserId(userID);
            mealsIngredients.Ingredients = ingredientRepository.GetByUserIdAndAllGeneric(userID);
            mealsIngredients.IngredientCategories = ingredientCategoryRepository.GetAll();

            return View(mealsIngredients);
        }

        [HttpPost]
        public int Add([FromBody] Meal meal)
        {
            var existingMeal = mealRepository.GetByName(meal.Name);

            if (existingMeal != null)
            {
                return 1;
            }

            if (meal.Name == null || !meal.Name.Any(character => char.IsLetter(character)))
            {
                return 2;
            }

            if (meal.Recipe == null || !meal.Recipe.Any(character => char.IsLetter(character)))
            {
                return 3;
            }

            mealRepository.Add(meal);

            return 0;
        }

        [HttpPatch]
        public void Update([FromBody] Meal meal)
        {
            mealRepository.Update(meal);
        }


        [HttpDelete]
        public void Delete([FromBody] Meal meal)
        {
            mealRepository.Delete(meal);
        }

        [HttpGet]
        public List<Meal> GetMeals(int userId)
        {
            return mealRepository.GetByUserId(userId);
        }
    }
}