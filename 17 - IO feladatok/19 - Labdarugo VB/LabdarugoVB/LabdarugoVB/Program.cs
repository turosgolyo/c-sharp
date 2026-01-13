using LabdarugoVB;
using System.Text;

List<Stadium> stadiums = new List<Stadium>();
try
{
    string[] lines = File.ReadAllLines("vb2018.txt", Encoding.UTF7);
    for (int i = 1; i < lines.Length; i++)
    {
        stadiums.Add(new Stadium(lines[i]));
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba a fájl beolvasásakor: {ex.Message}");
    return;
}

Console.WriteLine($"3. feladat: Stadionok száma: {stadiums.Count}");

Stadium minCapacityStadium = stadiums.OrderBy(s => s.Capacity).First();
Console.WriteLine("4. feladat: A legkevesebb férőhely:");
Console.WriteLine($"\tVáros: {minCapacityStadium.City}");
Console.WriteLine($"\tStadion neve: {minCapacityStadium.Name1}");
Console.WriteLine($"\tFérőhely: {minCapacityStadium.Capacity}");

double averageCapacity = stadiums.Average(s => s.Capacity);
Console.WriteLine($"5. feladat: Átlagos férőhelyszám: {averageCapacity:F1}");

int alternateNameCount = stadiums.Count(s => s.Name2 != "n.a.");
Console.WriteLine($"6. feladat: Két néven is ismert stadionok száma: {alternateNameCount}");

string inputCity = "";
do
{
    Console.Write("7. feladat: Kérem a város nevét: ");
    inputCity = Console.ReadLine();
} while (inputCity.Length < 3);

bool found = stadiums.Any(s => s.City.Equals(inputCity, StringComparison.OrdinalIgnoreCase));
if (found)
{
    Console.WriteLine("8. feladat: A megadott város VB helyszín.");
}
else
{
    Console.WriteLine("8. feladat: A megadott város nem VB helyszín.");
}

int distinctCitiesCount = stadiums.Select(s => s.City).Distinct().Count();
Console.WriteLine($"9. feladat: {distinctCitiesCount} különböző városban voltak mérkőzések.");

Console.ReadKey();