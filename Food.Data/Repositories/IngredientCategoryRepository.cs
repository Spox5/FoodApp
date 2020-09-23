//using Food.Data.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;



//namespace Food.Data.Repositories
//{
//    public class IngredientCategoryRepository
//    {
//        private readonly FoodContext foodContext;
//        public IngredientCategoryRepository(FoodContext foodContext)
//        {
//            this.foodContext = foodContext;
//        }
//        public List<IngredientCategory> GetAll()
//        {
//            return foodContext.IngredientCategories.ToList();
//        }

//        public List<IngredientCategory> GetByUserId(int userId)
//        {
//            return foodContext.IngredientCategories
//                .Where(type => type.UserId == userId)
//                .ToList();
//        }

//        //public List<Meal> GetByIngredients(List<int> ingredientIds)
//        //{
//        //    return foodContext.Meals
//        //        .Include(meal => meal.MealIngredients)
//        //        .Where(meal => meal.MealIngredients.All(mealIngredient => ingredientIds.Contains(mealIngredient.IngredientId)))
//        //        .ToList();
//        //}

//        public void Add(IngredientCategory ingredientType)
//        {
//            foodContext.IngredientCategories.Add(ingredientType);
//            foodContext.SaveChanges();
//        }

//        public void Update(IngredientCategory ingredientType)
//        {
//            foodContext.IngredientCategories.Update(ingredientType);
//            foodContext.SaveChanges();
//        }

//        public void Delete(IngredientCategory ingredientType)
//        {
//            foodContext.IngredientCategories.Remove(ingredientType);
//            foodContext.SaveChanges();
//        }
//    }
//}