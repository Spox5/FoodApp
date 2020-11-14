using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Data.Migrations
{
    public partial class Test_Insert_Meals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('KIESZENIE Z KURCZAKA ZE SZPINAKIEM I FETĄ', 0, 'fgh', 'Filety opłukać, osuszyć, oczyścić z błonek i kostek. Położyć na desce, każdą pierś przekroić pionowo na 2 połówki (otrzymamy 4 porcje kurczaka).
                W każdej połówce, od góry, zrobić pionowe głębsze nacięcie w kształcie krzyża. Rozchylić boki i poszerzyć nieco powstałą kieszonkę.
                Mięso doprawić z każdej strony przyprawami oraz startym czosnkiem, następnie natrzeć oliwą i odłożyć na ok. 30 minut lub dłużej jeśli mamy czas.
                Szpinak włożyć na patelnię i mieszając podgrzewać aż zmięknie, ostudzić. Wymieszać z pokrojonym w kostkę serem i wypełnić nadzieniem kieszonki.
                Na wierzchu położyć plaster pomidora, doprawić go solą, pieprzem, suszonym oregano. Ułożyć na blaszce do pieczenia, wstawić do piekarnika nagrzanego do 180 stopni C, piec przez ok. 35 minut.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('TORTILLE ZAPIEKANE PO MEKSYKAŃSKU', 0, 'fgh', 'Na dużej patelni na 2 łyżkach oleju zeszklić pokrojoną w kosteczkę cebulę (ok. 7 minut). Dodać zmielone mięso, posypać przyprawami i mieszając obsmażyć aż zmieni kolor. Przykryć i smażyć dalej na małym ogniu przez 15 minut.
                Dodać koncentrat pomidorowy, odcedzoną fasolkę i kukurydzę oraz (opcjonalnie) pokrojone suszone pomidory. Wymieszać i gotować wszystko jeszcze przez ok. 5 minut.
                Farsz wyłożyć na tortille, posypać serem (zachować ok. 1/3 ilości sera na wierzch) i zwinąć w rulony, ułożyć w naczyniu żaroodpornym.
                Krojone pomidory doprawić solą, pieprzem, szczyptą cukru i gotować przez ok. 10 minut bez przykrycia. Polać po tortillach i posypać pozostałym serem.
                Piec w piekarniku nagrzanym do 180 stopni C przez ok. 20 minut. Posypać listkami kolendry i podawać.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('KURCZAK PO TOSKAŃSKU', 0, 'fgh', 'Filety umyć, osuszyć, oczyścić z błonek i kostek. Przekroić wzdłuż na 2 cieńsze filety, odciąć polędwiczki.
                Całe mięso doprawić solą, pieprzem, oregano, natrzeć startym czosnkiem i wysmarować łyżką oliwy. Na tym etapie kurczaka można odstawić do zamarynowania (jeśli mamy czas).
                Mięso obtoczyć w mące, następnie kłaść na rozgrzaną dużą patelnię z 2 łyżkami oliwy i smażyć po ok. 3,5 minuty z każdej strony, aż kurczak ładnie się zrumieni. W razie potrzeby obsmażać na raty.
                Zdjąć kurczaka z patelni i odłożyć na talerz. Na tę samą patelnię wlać bulion i zagotować. Włożyć mięso i obłożyć pokrojonymi suszonymi pomidorami wyjętymi z zalewy. Gotować przez ok. 1 minutę, przewrócić na drugą stronę i powtórzyć gotowanie.
                Wlać śmietankę i zagotować. Posypać szpinakiem i wcisnąć go w sos aby listki zwiędły. Po ok. 1 - 2 minutach gotowania, gdy sos będzie już gęsty, odstawić danie z patelni.
                Podawać z wybranym dodatkiem posypując tartym serem.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('LECZO Z BATATAMI I CHORIZO', 0, 'fgh', 'Do garnka wlać oliwę, dodać pokrojoną na półplasterki cebulę oraz pokrojony w kosteczkę czosnek. Wymieszać i zeszklić na umiarkowanym ogniu przez 1 - 2 minuty.
                Zdjąć cienką skórkę z kiełbasy chorizo i pokroić na półplasterki. Dodać do garnka, wymieszać i podsmażać przez ok. 2 - 3 minuty.
                Dodać obranego i pokrojonego w kostkę batata i wszystko wymieszać. Podsmażać przez ok. 2 - 3 minuty.
                Dodać pokrojoną w kostkę cuknię, przyprawy, doprawić solą i pieprzem oraz wlać bulion. Zagotować.
                Dodać pokrojoną w kostkę paprykę, delikatnie wymieszać i gotować pod lekko uchyloną pokrywą przez ok. 5 minut. W międzyczasie 1 raz zamieszać.
                Dodać pomidory (jeśli są w całości, z puszki - należy je posiekać). Dodać koncentrat pomidorowy, wymieszać i gotować przez ok. 5 minut.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('ZUPA Z CUKINIĄ, ZIEMNIAKAMI I FETĄ', 0, 'fgh', 'W garnku na oliwie i maśle zeszklić pokrojoną w kosteczkę cebulę (co chwilę mieszając, na średnim ogniu, ok. 5 minut).
                Dodać obrane i pokrojone w małą kostkę ziemniaki i wymieszać. Podsmażać razem przez ok. 2 - 3 minuty co chwilę mieszając.
                Dodać starty czosnek, wlać bulion i zagotować. W międzyczasie dodać kurkumę, pieprz oraz w razie potrzeby sól do smaku.
                Po zagotowaniu gotować zupę przez ok. 2 - 3 minuty, następnie dodać pokrojoną w kostkę cukinię (nieco większą niż ziemniaki). Gotować przez ok. 8 - 10 minut.
                Odstawić z ognia, dodać koperek oraz śmietankę. Podawać z fetą oraz pieczywem.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('ŁOSOŚ W SOSIE KURKOWYM', 0, 'fgh', 'Odciąć skórkę z łososia. Rybę opłukać, osuszyć i pokroić na mniejsze porcje. Doprawić solą, pieprzem, połową kurkumy, całą papryką słodką i ostrą. Następnie wymieszać z sokiem z cytryny i 1 łyżką oliwy. Odłożyć do zamarynowania na kilka godzin - jeśli mamy czas.
                Kurki umyć i osuszyć. Rozgrzać drugą łyżkę oliwy na większej patelni. Łososia obtoczyć delikatnie w mące i włożyć na patelnię. Smażyć po 2 minuty z każdej strony, następnie wyłożyć na talerz.
                Na tę samą patelnię włożyć pokrojoną w kosteczkę cebulę i zeszklić ją. Dodać starty czosnek a następnie kurki i smażyć przez ok. 2 - 3 minuty co chwilę mieszając.
                Łososia włożyć z powrotem na patelnię, wlać śmietankę, dodać resztę kurkumy, koperek i delikatnie posolić sos.
                Delikatnie potrząsać patelnią w celu wymieszania składników sosu i gotować przez ok. 2 minuty. Podawać z ziemniakami lub makaronem.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('ŁOSOŚ W SOSIE CURRY ZE SZPINAKIEM I SUSZONYMI POMIDORAMI', 0, 'fgh', 'Odciąć skórę z łososia, pokroić go na porcje, doprawić solą, pieprzem, następnie natrzeć przyprawą curry i obtoczyć w łyżce oliwy. Odłożyć do zamarynowania na kilka godzin (jeśli mamy czas).
                Umyć i osuszyć szpinak. Suszone pomidory pokroić na kawałki.
                Rozgrzać większą patelnię z oliwą (ok. 2 łyżki). Kawałki łososia obtoczyć w mące pszennej i położyć na patelni. Smażyć na większym ogniu przez około 2 minuty, następnie przewrócić na drugą stronę i powtórzyć smażenie.
                Pomiędzy kawałki łososia włożyć suszone pomidory. Na wierzch wysypać szpinak. Zalać śmietanką i na większym ogniu gotować przez ok. 2 minuty, co chwilę poruszając patelnią. Doprawić delikatnie solą i pieprzem w razie potrzeby.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('KURCZAK Z KURKAMI', 0, 'fgh', 'Kurczaka oczyścić z błonek i kostek, pokroić na mniejsze filety: odkroić polędwiczkę, następnie filet przekroić pionowo na dwie połówki. Grubszą połówkę przekroić jeszcze wzdłuż na 2 cieńsze części.
                Mięso rozbić tłuczkiem na jednakową grubość, ok. 1 cm. Doprawić solą, pieprzem, kurkumą, paprykami. Wymieszać z łyżką oleju. Odłożyć do lodówki na kilka godzin lub na noc - jeśli mamy oczywiście czas.
                Kurki umyć, osuszyć. Cebulę pokroić w kosteczkę. Filety delikatnie obtoczyć w mące. Rozgrzać patelnię z oliwą lub olejem. Włożyć filety kurczaka, podsmażać po ok. 2 minuty z każdej strony. Odłożyć na talerz.
                Na tę samą patelnię włożyć cebulę i zeszklić ją. Następnie dodać kurki i smażyć mieszając przez ok. 2 - 3 minuty.
                Włożyć mięso na patelnię i wsunąć ją miejscami pomiędzy kurki. Trzymając danie na ogniu wlać bulion, dodać koperek, wymieszać i zagotować.
                Po chwili wlać śmietankę i delikatnie przemieszać składniki. Gotować jeszcze przez ok. 1 - 2  minuty aż sos zgęstnieje, w międzyczasie 1 - 2 razy przewrócić mięso.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('KURCZAK W SOSIE Z CUKINIĄ I GORGONZOLĄ', 0, 'fgh', 'Kurczaka oczyścić z błonek i kostek, pokroić na mniejsze filety: odkroić polędwiczkę - ruchomą część filetu, następnie filet przekroić wzdłuż na 2 cieńsze części. Rozbić tłuczkiem na jednakową grubość, ok. 1 cm. Doprawić solą oraz pieprzem.
                Cukinię przyciąć na końcach i pokroić w niedużą kostkę.
                Filety delikatnie obtoczyć w mące. Rozgrzać patelnię z oliwą lub olejem. Włożyć filety kurczaka, podsmażać po ok. 2 minuty z każdej strony. Odłożyć na talerz.
                Na tę samą patelnię wrzucić cukinię i smażyć co chwilę mieszając przez ok. 3 - 4 minuty. W międzyczasie dodać masło.
                Dodać całe mięso na patelnię i wsunąć ją miejscami pod cukinię. Trzymając danie na ogniu wlać bulion, dodać kurkumę, koperek i szczypiorek. Wymieszać i zagotować.
                Po chwili wlać śmietankę i delikatnie przemieszać składniki. Posypać posiekaną gorgonzolą. Doprawić w razie potrzeby solą i pieprzem i gotować jeszcze przez minutę.', 2);

                INSERT INTO [Food].[dbo].[Meals] ([Name], [UserId], [Ingredients], [Recipe], [CategoryId])
                VALUES ('CHŁOPSKI GARNEK Z CUKINIĄ', 0, '2 łyżki oleju roślinnego, 1 cebula, 150 g parzonego boczku, 400 g kiełbasy (np. wiejskiej), 500 ml bulionu, 
                3 ziemniaki, 2 łyżeczki majeranku, 1 łyżeczka słodkiej papryki, 1/2 łyżeczki pieprzu cayenne, 1 czerwona papryka, 1 cukinia (ok. 300 g), 2/3 szklanki przecieru pomidorowego (passaty)', 'Do szerokiego i dużego garnka (najlepiej z grubym dnem) wlać olej. Dodać obraną i pokrojoną w kosteczkę cebulę i chwilę ją poddusić.
                Następnie dodać pokrojony w kostkę boczek i mieszając co chwilę smażyć na umiarkowanym ogniu przez ok. 5 minut, aż cebula się zeszkli a boczek zacznie się rumienić.
                Dodać obrane i pokrojone w małą kostkę ziemniaki, wymieszać i chwilę razem podsmażać.
                Dodać pokrojoną w większą kostkę cukinię oraz pokrojoną na większe paski paprykę. 
                Doprawić majerankiem, papryką oraz pieprzem cayenne. Wymieszać i chwilę razem podsmażać.
                Dodać pokrojoną na plasterki kiełbasę (w razie potrzeby można ją obrać).
                Zalać gorącym bulionem, przykryć i gotować przez ok. 10 minut, do czasu aż ziemniaki będą miękkie.
                Wlać przecier, wymieszać i gotować przez ok. 2 minuty.', 2);
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
