using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Insert_User_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[IngredientCategories] ([Name])
                VALUES ('Użytkownika');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
