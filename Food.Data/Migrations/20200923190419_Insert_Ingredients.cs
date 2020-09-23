using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Insert_Ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pomarańcza', 0, 1);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Truskawka', 0, 1);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ogórek', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z kurczaka', 0, 3);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
