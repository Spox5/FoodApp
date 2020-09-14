using Food.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Food.Data.Repositories
{
    public class IngredientTypeRepository
    {
        private readonly FoodContext foodContext;
        public IngredientTypeRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }
        public List<IngredientType> GetAll()
        {
            return foodContext.IngredientTypes.ToList();
        }

        public List<IngredientType> GetByUserId(int userId)
        {
            return foodContext.IngredientTypes
                .Where(type => type.UserId == userId)
                .ToList();
        }

        //public List<Meal> GetByIngredients(List<int> ingredientIds)
        //{
        //    return foodContext.Meals
        //        .Include(meal => meal.MealIngredients)
        //        .Where(meal => meal.MealIngredients.All(mealIngredient => ingredientIds.Contains(mealIngredient.IngredientId)))
        //        .ToList();
        //}

        public void Add(IngredientType ingredientType)
        {
            foodContext.IngredientTypes.Add(ingredientType);
            foodContext.SaveChanges();
        }

        public void Update(IngredientType ingredientType)
        {
            foodContext.IngredientTypes.Update(ingredientType);
            foodContext.SaveChanges();
        }

        public void Delete(IngredientType ingredientType)
        {
            foodContext.IngredientTypes.Remove(ingredientType);
            foodContext.SaveChanges();
        }
    }
}