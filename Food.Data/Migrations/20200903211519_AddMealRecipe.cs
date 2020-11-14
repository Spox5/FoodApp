﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class AddMealRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recipe",
                table: "Meals",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Meals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recipe",
                table: "Meals");
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Meals");
        }
    }
}
