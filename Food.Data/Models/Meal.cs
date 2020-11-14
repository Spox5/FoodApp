using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Food.Data.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Recipe { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public List<MealIngredient> MealIngredients { get; set; }
    }
}
