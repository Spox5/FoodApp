using System.Collections.Generic;
using System.Dynamic;

namespace Food.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public List<MealIngredient> MealIngredients { get; set; }
    }
}
