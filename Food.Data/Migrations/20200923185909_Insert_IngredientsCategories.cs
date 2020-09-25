using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Insert_IngredientsCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Owoce');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Warzywa');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Mięso');


                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Ryby');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Kasze i makarony');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Przyprawy');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Nabiał');

                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Pieczywo');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
