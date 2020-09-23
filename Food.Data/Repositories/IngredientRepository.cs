using Food.Data.Models;
using Microsoft.EntityFrameworkCore;
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

        public Ingredient GetByName(string name)
        {
            return foodContext.Ingredients.FirstOrDefault(ingredient => ingredient.Name == name);
        }

        public void Add(Ingredient ingredient)
        {
            foodContext.Ingredients.Add(ingredient);
            foodContext.SaveChanges();
        }

        public void Update(Ingredient ingredient)
        {
            foodContext.Ingredients.Update(ingredient);
            foodContext.SaveChanges();
        }

        public void Delete(Ingredient ingredient)
        {
            foodContext.Ingredients.Remove(ingredient);
            foodContext.SaveChanges();
        }
    }
}
