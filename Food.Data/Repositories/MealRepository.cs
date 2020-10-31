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
                .Include(meal => meal.MealIngredients)
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

        public Meal GetByName(string name)
        {
            return foodContext.Meals.FirstOrDefault(meal => meal.Name == name);
        }

        public void Add(Meal meal)
        {
            foodContext.Meals.Add(meal);
            foodContext.SaveChanges();
        }

        public void Update(Meal meal)
        {
            var mealToUpdate = foodContext.Meals
                .Include(meal => meal.MealIngredients)
                .FirstOrDefault(existingMeal => existingMeal.Id == meal.Id);

            mealToUpdate.CategoryId = meal.CategoryId;
            mealToUpdate.Name = meal.Name;
            mealToUpdate.Recipe = meal.Recipe;
            mealToUpdate.UserId = meal.UserId;

            mealToUpdate.MealIngredients.Clear();
            mealToUpdate.MealIngredients.AddRange(meal.MealIngredients);

            foodContext.Meals.Update(mealToUpdate);
            foodContext.SaveChanges();
        }

        public void Delete(Meal meal)
        {
            foodContext.Meals.Remove(meal);
            foodContext.SaveChanges();
        }
    }
}