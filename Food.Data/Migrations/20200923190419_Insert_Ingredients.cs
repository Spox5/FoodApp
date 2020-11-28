using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Insert_Ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
--1
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z kurczaka', 0, 3);

--2
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sól', 0, 6);

--3
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pieprz', 0, 6);

--4
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kurkuma', 0, 6);

--5
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Słodka papryka', 0, 6);

--6
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Oregano/zioła prowansalskie', 0, 6);

--7
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ostra papryka', 0, 6);

--8
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Czosnek', 0, 2);

--9
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Olej/Oliwa (np. extra vergine)', 0, 9);

--10
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szpinak', 0, 2);

--11
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ser feta', 0, 7);

--12
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pomidor', 0, 2);

--13
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Tortilla', 0, 9);

--14
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cebula', 0, 2);

--15
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mięso mielone', 0, 3);

--16
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Koncentrat/przecier pomidorowy', 0, 9);

--17
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Czerwona fasola', 0, 2);

--18
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kukurydza', 0, 2);

--19
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Krojone pomidory w puszce', 0, 9);

--20
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Żółty ser', 0, 7);

--21
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Bulion', 0, 9);

--22
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Śmietanka do zup 30%', 0, 7);

--23
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Suszone pomidory', 0, 9);

--24
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kiełbasa Chorizo', 0, 3);

--25
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Batat', 0, 2);

--26
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cukinia', 0, 2);

--27
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Papryka', 0, 2);

--28
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Masło/smalec', 0, 9);

--29
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ziemniaki', 0, 2);

--30
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z łososia/łosoś wędzony', 0, 4);

--31
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kurki', 0, 2);

--32
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mąka przenna', 0, 9);

--33
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Curry/pasta curry', 0, 6);

--34
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Koperek', 0, 6);

--35
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szczypiorek', 0, 6);

--36
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Gorgonzola', 0, 7);

--37
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Boczek parzony', 0, 3);

--38
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kiełbasa', 0, 3);

--39
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Majeranek', 0, 6);

--40
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pieprz cayenne', 0, 6);

--41
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Passata pomidorowa', 0, 9);
--42
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Makaron', 0, 5);
--43
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Truskawki', 0, 1);
--44
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cukier', 0, 6);
--45
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Śmietana 18%/homogenizowana', 0, 7);
--46
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szparagi', 0, 2);
--47
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ciecierzyca', 0, 2);
--48
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Przyprawa gyros', 0, 6);
--49
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Szynka zwykła/suszona/parmeńska', 0, 3);
--50
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mozzarella', 0, 7);
--51
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet z dorsza', 0, 4);
--52
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Żur', 0, 9);
--53
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Boczek wędzony', 0, 3);
--54
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Jaja', 0, 7);
--55
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Bułka tarta', 0, 9);
--56
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Natka pietruszki', 0, 2);
--57
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Parmezan', 0, 7);
--58
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ryż', 0, 5);
--59
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mleko kokosowe', 0, 9);
--60
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Zielona pasta curry', 0, 9);
--61
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pieczarki', 0, 2);
--62
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Krewetki', 0, 4);
--63
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Słodki sos chili', 0, 9);
--64
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sos worcestershire', 0, 9);
--65
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Cytryna', 0, 1);
--66
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Tymianek', 0, 6);
--67
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Limonka', 0, 1);
--68
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Masło orzechowe', 0, 9);
--69
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Bazylia', 0, 6);
--70
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sos sojowy', 0, 9);
--71
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sos rybny', 0, 9);
--72
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Bakłażan', 0, 2);
--73
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Wołowina', 0, 3);
--74
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Imbir', 0, 6);
--75
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Olej sezamowy', 0, 9);
--76
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mąka ziemniaczana', 0, 9);
--77
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Brokuł', 0, 2);
--78
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Orzeszki (nerkowce, pinii, ziemne)', 0, 9);
--79
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kasza orkiszowa', 0, 5);
--80
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Jarmuż', 0, 2);
--81
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Filet/udziec z indyka', 0, 3);
--82
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kminek', 0, 6);
--83
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Liście laurowe', 0, 6);
--84
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mleko', 0, 7);
--85
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Dynia', 0, 2);

--86
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Marchewka', 0, 2);
--87
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kopytka', 0, 9);
--88
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Por', 0, 2);
--89
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Gałka muszkatołowa', 0, 6);
--90
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Fasolka szparagowa', 0, 2);
--91
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Schab', 0, 3);
--92
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Polędwica', 0, 3);
--93
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kasza pęczak', 0, 5);
--94
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kmin rzymski/kumin', 0, 6);
--95
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Musztarda', 0, 9);
--96
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ananas', 0, 1);
--97
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ketchup', 0, 9);
--98
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Soczewica', 0, 2);
--99
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mango', 0, 1);
--100
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ocet/ocet ryżowy', 0, 9);
--101
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Groszek zielony/cukrowy', 0, 2);
--102
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sezam', 0, 9);
--103
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Płatki kukurydziane', 0, 9);
--104
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kasza gryczana', 0, 5);
--105
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Botwinka/buraki', 0, 2);
--106
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Sos rybny', 0, 9);
--107
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ziele angielskie', 0, 6);
--108
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Serek inny (np. kremowy)', 0, 7);
--109
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Ser gorgonzola', 0, 7);
--110
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Pestki słonecznika', 0, 9);
--111
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kiszone ogórki', 0, 9);
--112
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kapusta pekińska', 0, 2);
--113
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kasza jaglana', 0, 5);
--114
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Mięta', 0, 6);
--115
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Czarnuszka', 0, 6);
--116
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Kapusta', 0, 2);
--117
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Jogurt', 0, 7);
--118
                INSERT INTO [Food].[dbo].[Ingredients] ([Name], [UserId], [CategoryId])
                VALUES ('Chleb', 0, 9);



            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
