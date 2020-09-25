using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_Meals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Recipe], [CategoryId])
                VALUES ('Koktajl', 0, 'Wrzuć truskawki do blendera i zblenduj. Podawaj w wysokich szklankach', 1);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Recipe], [CategoryId])
                VALUES ('Ogórek z truskawką', 0, 'Pokroj ogórek w paski. Truskawki porozkładaj na talerzu. Połącz truskawki paska z ogórka', 1);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Recipe], [CategoryId])
                VALUES ('Kurczak z pomarańczą', 0, 'Filet pokrój w paski i podsmaż na patelni około 5 min. Następnie dodaj pokrojoną w 
                kostkę pomarańczę i mieszaj 1 minutę. Całość nałóż na głęboki talerz. Najlepiej podawać ze słodkim winem.', 2);

            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
