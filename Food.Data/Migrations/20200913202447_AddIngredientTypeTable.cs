using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class AddIngredientTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "Ingredients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IngredientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientTypes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Ingredients");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
