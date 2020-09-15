using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class AddTable_MealCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientTypes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Ingredients");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Meals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "IngredientCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MealCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealCategory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientCategories");

            migrationBuilder.DropTable(
                name: "MealCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Ingredients");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "IngredientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTypes", x => x.Id);
                });
        }
    }
}
