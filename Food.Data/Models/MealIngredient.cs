using System.Text.Json;
using System.Text.Json.Serialization;



namespace Food.Data.Models
{
    public class MealIngredient
    {
        public int MealId { get; set; }

        [JsonIgnore]
        public Meal Meal { get; set; }
        public int IngredientId { get; set; }

        [JsonIgnore]
        public Ingredient Ingredient { get; set; }
    }
}