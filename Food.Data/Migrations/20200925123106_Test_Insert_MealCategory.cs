using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_MealCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

            INSERT INTO[Food].[dbo].[MealCategory] ([Name], [UserId])
            VALUES('Śniadanie', 0);

            INSERT INTO[Food].[dbo].[MealCategory] ([Name], [UserId])
            VALUES('Obiad', 0);

            INSERT INTO[Food].[dbo].[MealCategory] ([Name], [UserId])
            VALUES('Kolacja', 0);

            INSERT INTO[Food].[dbo].[MealCategory] ([Name], [UserId])
            VALUES('Przekąska', 0);

            INSERT INTO[Food].[dbo].[MealCategory] ([Name], [UserId])
            VALUES('Deser', 0);

            ");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
