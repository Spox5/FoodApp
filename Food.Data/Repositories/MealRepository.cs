using Food.Data.Models;
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

        public List<Meal> GetByIngredients(List<Ingredient> ingredients)
        {
            List<Meal> meals =null;

            

            return meals;
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
