using Food.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Food.Data.Repositories
{
    public class IngredientCategoryRepository
    {
        private readonly FoodContext foodContext;
        public IngredientCategoryRepository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }
        public List<IngredientCategory> GetAll()
        {
            return foodContext.IngredientCategories.ToList();
        }
    }
}