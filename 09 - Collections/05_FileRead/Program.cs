/*
Adva van az adatok.txt állományban a Magyar Női Röplabda Bajnogság csapatainak pontászámai a következő képpen:

Békéscsaba
1,2,1,3,3,3,3,3,3,3,1,2,2,1,3,3,1,3

ahol a csapat nevét sortöréssel elválasztva követik a az elért pontok mérközésenként (max 18 lejátszott mérközés).

- Hány csapat vett részt a bajnokságban?
- Ki nyerte a bajnogságot?
- Döntetlen mérkőzéskor a csapat 2 pontot szerez. Mutassa be csapatonként ki hány döntetlen mérkőzést játszott le!
- Ha egy mérkőzés 5 szetben dől el, akkor a vesztes csapat 1 pontot szerez. Mely csapatok játszottak 5 szettes mérkőzést és hányat?
- Ki a  bajnogság első három helyezete. Mutassa be mintának megfelelően:
	helyezés - csapat neve		pontszám
- Az elért pontok alapján, az utolsó három csapat kiesik az első osztályból. Kik ők?
- Mutassa be csapatonként a győzelmi és verességi arányt csapatonként!
- Mely csapatok győzelmi aránya van az átlag alatt?
*/

// beolvasas, kiiras
using CustomLibrary.ConsoleExtensions;

List<Volleyball> teams = await FileService.ReadFromFileAsync("adatok.txt");
ExtendedSystem.WriteCollectionToConsole(teams);

// csapatok szama
int teamCount = teams.Count;
Console.WriteLine($"A bajnoksagon {teamCount} csapat vett reszt.");

// dontetlen merkozesek
List<DrawMatches> drawMatches = teams.Select(x => new DrawMatches
{
    Name = x.Name,
    Draw = x.Points.Count(x => x == 2)
}).ToList();
Console.WriteLine("\nDontetlen merkozesek szama:");
ExtendedSystem.WriteCollectionToConsole(drawMatches);

// 5 szettes merkozesek
List<FiveSetMatches> fiveSetMatches = teams.Select(x => new FiveSetMatches
{
    Name = x.Name,
    Matches = x.Points.Count(x => x == 1)
}).ToList();
Console.WriteLine("\n5 szettes merkozesek szama:");
ExtendedSystem.WriteCollectionToConsole(fiveSetMatches);

// legjobb 3 csapat
List<Volleyball> bestThreeTeams = teams.OrderByDescending(x => x.Points.Sum())
                                       .Take(3)
                                       .ToList();
Console.WriteLine("Legjobb 3 csapat");
int i = 0;
foreach(Volleyball team in bestThreeTeams)
{
    i++;
    Console.WriteLine($"{i}. - {team.Name} - {team.Points.Sum()}");
}

// legrosszabb 3 csapat
List<Volleyball> worstThreeTeams = teams.OrderBy(x => x.Points.Sum())
                                        .Take(3)
                                        .ToList();
Console.WriteLine("Legrosszabb 3 csapat");
foreach (Volleyball team in bestThreeTeams)
{
    Console.WriteLine($"{team.Name} - {team.Points.Sum()}");
}

// gyozelmi arany
List<WinLoseRatio> teamRatios = teams.Select(x => new WinLoseRatio
{
    Name = x.Name,
    Wins = x.Points.Count(x => x == 3),
    Losses = x.Points.Count(x => x == 0)
}).ToList();
Console.WriteLine("\nGyozelmi arany:");
ExtendedSystem.WriteCollectionToConsole(teamRatios);