using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_Meals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
--1
                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('KIESZENIE Z KURCZAKA ZE SZPINAKIEM I FETĄ', 0, '2 pojedyncze filety kurczaka,
                przyprawy: po 1 łyżeczce soli, pieprzu, kurkumy, słodkiej papryki, suszonego oregano, 1/2 łyżeczki ostrej papryki, 
                2 ząbki czosnku, 
                1 łyżka oliwy lub oleju, 
                200 g szpinaku, 
                100 g sera feta lub sera sałatkowego, 
                1 pomidor', 'Filety opłukać, osuszyć, oczyścić z błonek i kostek. Położyć na desce, każdą pierś przekroić pionowo na 2 połówki (otrzymamy 4 porcje kurczaka).
                W każdej połówce, od góry, zrobić pionowe głębsze nacięcie w kształcie krzyża. Rozchylić boki i poszerzyć nieco powstałą kieszonkę.
                Mięso doprawić z każdej strony przyprawami oraz startym czosnkiem, następnie natrzeć oliwą i odłożyć na ok. 30 minut lub dłużej jeśli mamy czas.
                Szpinak włożyć na patelnię i mieszając podgrzewać aż zmięknie, ostudzić. Wymieszać z pokrojonym w kostkę serem i wypełnić nadzieniem kieszonki.
                Na wierzchu położyć plaster pomidora, doprawić go solą, pieprzem, suszonym oregano. Ułożyć na blaszce do pieczenia, wstawić do piekarnika nagrzanego do 180 stopni C, piec przez ok. 35 minut.', 2);

            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
