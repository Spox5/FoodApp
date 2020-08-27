using Food.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Data
{
    public class FoodContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }

        public FoodContext(DbContextOptions<FoodContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MealIngredient>()
            .HasKey(mealIngredient => new { mealIngredient.MealId, mealIngredient.IngredientId });

            modelBuilder.Entity<MealIngredient>()
                .HasOne(mealIngredient => mealIngredient.Meal)
                .WithMany(meal => meal.MealIngredients)
                .HasForeignKey(mealIngredient => mealIngredient.MealId);

            modelBuilder.Entity<MealIngredient>()
                .HasOne(mealIngredient => mealIngredient.Ingredient)
                .WithMany(ingredient => ingredient.MealIngredients)
                .HasForeignKey(mealIngredient => mealIngredient.IngredientId);

        }
    }
}
