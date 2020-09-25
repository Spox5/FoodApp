using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_MealIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 2);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 1);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 2);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 1);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 3);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 4);

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
