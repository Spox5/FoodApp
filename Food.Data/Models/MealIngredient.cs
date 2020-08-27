using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Food.Data.Models
{
    public class MealIngredient
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
