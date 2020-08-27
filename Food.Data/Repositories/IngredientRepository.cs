using Food.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Food.Data.Repositories
{

    public class IngredientRepository
    {
        private readonly FoodContext foodContext;
        public IngredientRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }
        public List<Ingredient> GetAll()
        {
            return foodContext.Ingredients.ToList();
        }

        public List<Ingredient> GetByUserId(int userId)
        {
            return foodContext.Ingredients
                .Where(ingredient => ingredient.UserId == userId)
                .ToList();
        }

        public void Add(Ingredient ingredient)
        {
            foodContext.Ingredients.Add(ingredient);
            foodContext.SaveChanges();
        }

        public void Delete(Ingredient ingredient)
        {
            foodContext.Ingredients.Remove(ingredient);
            foodContext.SaveChanges();
        }
    }
}
