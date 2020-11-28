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

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(11, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(11, 43);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(11, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(11, 45);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 46);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(12, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 24);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 47);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(13, 41);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 37);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 38);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 39);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(14, 41);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 48);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 49);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 19);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 47);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 50);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(15, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(16, 46);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(16, 51);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(16, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(16, 24);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(16, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 52);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 45);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 39);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(17, 38);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 15);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 55);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 37);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 57);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(18, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 60);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(19, 10);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 62);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 63);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 64);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 65);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 66);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(20, 5);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 67);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 68);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(21, 69);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 62);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 60);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 71);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 72);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(22, 67);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 73);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 77);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 75);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(23, 58);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 16);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(24, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 69);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 78);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 57);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(25, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(26, 79);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(26, 80);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(26, 24);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(26, 8);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 83);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 82);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 39);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(27, 16);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 49);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(28, 20);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 51);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 84);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(29, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 62);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(30, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 85);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(31, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 62);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 40);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(32, 44);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 87);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 50);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 41);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(33, 3);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(34, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 31);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(35, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(36, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 77);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 84);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 49);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(37, 57);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 57);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 89);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(38, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 15);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 17);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(39, 50);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(40, 57);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 31);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(41, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 90);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(42, 3);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 65);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 34);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(43, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 91);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(44, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 92);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 46);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(45, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 51);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 35);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(46, 76);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 94);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 16);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 17);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 20);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(47, 35);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 25);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 47);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(48, 10);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(49, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 94);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 17);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 19);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(50, 20);



            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(51, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 55);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 57);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 20);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(52, 26);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 92);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 95);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(53, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 96);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(54, 97);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 92);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 97);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 65);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(55, 70);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 25);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 98);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(56, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 53);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(57, 3);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 92);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 76);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 99);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 100);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(58, 44);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 100);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 101);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(59, 102);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 11);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(60, 6);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(61, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 84);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 103);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(62, 28);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 104);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(63, 27);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 90);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(64, 35);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 66);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 105);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(65, 21);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 106);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(66, 59);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 84);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(67, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 7);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(68, 20);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(69, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 37);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(70, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 19);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 17);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 20);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 94);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(71, 5);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 101);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(72, 28);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 83);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 107);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(73, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(74, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(74, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(74, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(74, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(74, 9);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 108);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(75, 65);
\
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 37);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 109);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 69);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(76, 12);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 47);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 85);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 4);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(77, 10);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 72);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(78, 50);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(79, 34);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 104);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 110);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 56);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(80, 11);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(81, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(81, 49);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(81, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(81, 50);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 111);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 45);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(82, 35);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 38);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 41);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(83, 26);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 90);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(84, 70);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 104);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 112);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(85, 70);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 104);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 112);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(86, 21);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 94);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 26);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(87, 56);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 113);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 11);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 114);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(88, 65);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 66);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 65);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(89, 3);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(90, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(90, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(90, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 58);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 77);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 68);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(91, 115);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 101);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 35);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 75);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(92, 70);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 38);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 2);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 3);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(93, 41);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 77);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 102);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 100);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 44);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 74);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(94, 8);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 30);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 65);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(95, 22);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 93);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 88);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 81);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 70);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 116);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 46);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(96, 35);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 86);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 29);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 117);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 34);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 35);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(97, 45);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 23);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 10);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(98, 11);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 6);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 61);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(99, 28);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 12);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 18);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 21);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 41);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(100, 58);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(101, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(101, 27);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(101, 33);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(101, 59);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(101, 45);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 1);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 28);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 32);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 5);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 16);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 22);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(102, 34);

--własne
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(103, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(103, 28);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(104, 42);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(104, 14);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(104, 8);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(104, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(104, 41);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(105, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(105, 117);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(105, 9);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(105, 32);

            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(106, 118);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(106, 54);
            INSERT INTO[Food].[dbo].[MealIngredient] ([MealId], [IngredientId])
            VALUES(106, 59);


            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
