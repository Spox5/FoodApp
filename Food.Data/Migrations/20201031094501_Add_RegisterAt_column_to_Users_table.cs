using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Add_RegisterAt_column_to_Users_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterAt",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisterAt",
                table: "Users");
        }
    }
}
