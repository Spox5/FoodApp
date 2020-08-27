using System.Collections.Generic;

namespace Food.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public List<MealIngredient> MealIngredients { get; set; }
    }
}
