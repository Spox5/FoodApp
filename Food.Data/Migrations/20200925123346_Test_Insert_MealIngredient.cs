using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_MealIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 11);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(1, 12);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 13);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 15);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 16);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 17);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 19);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 20);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(2, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(3, 20);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 24);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 25);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 19);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(4, 16);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(5, 11);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 31);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(6, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(7, 32);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 31);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 34);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(8, 32);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 34);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 35);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(9, 36);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 37);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 38);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 39);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 40);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(10, 41);

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
