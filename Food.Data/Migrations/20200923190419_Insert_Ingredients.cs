using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Insert_Ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z kurczaka', 0, 3);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sól', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pieprz', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kurkuma', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Słodka papryka', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Oregano', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ostra papryka', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Czosnek', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Olej/Oliwa', 0, 9);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szpinak', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ser feta', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pomidor', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Tortilla', 0, 9);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cebula', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mięso mielone', 0, 3);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Koncentrat pomidorowy', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Czerwona fasola', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kukurydza', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Krojone pomidory w puszce', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Żółty ser', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Bulion', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Śmietanka do zup', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Suszone pomidory', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kiełbasa Chorizo', 0, 3);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Batat', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cukinia', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Papryka', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Masło', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ziemniaki', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z łososia', 0, 4);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kurki', 0, 2);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mąka przenna', 0, 9);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Curry', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Koperek', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szczypiorek', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Gorgonzola', 0, 7);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Boczek parzony', 0, 3);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kiełbasa', 0, 3);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Majeranek', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pieprz cayenne', 0, 6);

                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Passata pomidorowa', 0, 2);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
