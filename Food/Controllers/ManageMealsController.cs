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

    public class ManageMealsController : Controller
    {
        private readonly MealRepository mealRepository;
        private readonly IngredientRepository ingredientRepository;



        public ManageMealsController(MealRepository mealRepository, IngredientRepository ingredientRepository)
        {
            this.mealRepository = mealRepository;
            this.ingredientRepository = ingredientRepository;
        }



        [HttpGet]
        public IActionResult Index(int userID)
        {
            var mealsIngredients = new SearchMealViewModel();
            mealsIngredients.Meals = mealRepository.GetByUserId(userID);
            mealsIngredients.Ingredients = ingredientRepository.GetByUserId(userID);



            return View(mealsIngredients);
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
    }
}