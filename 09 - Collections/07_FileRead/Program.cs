using CustomLibrary.ConsoleExtensions;

List<Player> players = await FileService.ReadFromFileAsync("balkezesek.csv");

//3. feladat
int linesCount = players.Count();
Console.WriteLine($"3. Feladat: {linesCount}");

//4. feladat
foreach (Player player in players.Where(x => x.Last.Year == 1999 && x.Last.Month == 10))
{
    Console.WriteLine($"{player.Name}, {player.HeightInCentiMeters} cm");
}
//5. feladat

string temp;
int year;
bool isNumber = false;
do
{
    Console.WriteLine("Adjon meg 1999 és 1900 közti számot!");
    temp = Console.ReadLine();
    isNumber = int.TryParse(temp, out year);
    if(!isNumber || year < 1900 || year > 1999)
    {
        Console.WriteLine("Hibás adat!");
    }
} 
while (!isNumber || year <= 1900 || year >= 1999);

//6. feladat
List<Player> playersByYear = players.Where(x => x.First.Year <= year && x.Last.Year >= year).ToList();
double averageWeight = Math.Round(playersByYear.Average(x => x.Weight), 2);

Console.WriteLine($"6. Feladat: {year} évben a játékosok átlagos súlya: {averageWeight} font");

