using Food.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Food.Data.Repositories
{
    
    public class MealRepository
    {
        private readonly FoodContext foodContext;
        public MealRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }
        public List<Meal> GetAll()
        {
            return foodContext.Meals.ToList();
        }

        public List<Meal> GetByUserId(int userId)
        {
            return foodContext.Meals
                .Where(meal => meal.UserId == userId)
                .ToList();
        }

        public List<Meal> GetByIngredients(List<int> ingredientIds)
        {
            return foodContext.Meals
                .Include(meal => meal.MealIngredients)
                .Where(meal => meal.MealIngredients.All(mealIngredient => ingredientIds.Contains(mealIngredient.IngredientId)))
                .ToList();
        }

        public void Add(Meal meal)
        {
            foodContext.Meals.Add(meal);
            foodContext.SaveChanges();
        }
        public void Delete(Meal meal)
        {
            foodContext.Meals.Remove(meal);
            foodContext.SaveChanges();
        }

    }
}
