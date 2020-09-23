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
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
