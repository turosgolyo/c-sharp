using NobelDijak;
using System.Text;


List<NobelPrize> prizes = new List<NobelPrize>();
string[] lines = File.ReadAllLines("nobel.csv", Encoding.UTF8);

for (int i = 1; i < lines.Length; i++)
{
    if (!string.IsNullOrWhiteSpace(lines[i]))
    {
        prizes.Add(new NobelPrize(lines[i]));
    }
}

var arthur = prizes.First(p => p.FirstName == "Arthur B." && p.LastName == "McDonald");
Console.WriteLine($"3. feladat: {arthur.Type}");

var literature2017 = prizes.First(p => p.Year == 2017 && p.Type == "irodalmi");
Console.WriteLine($"4. feladat: {literature2017.FirstName} {literature2017.LastName}");

Console.WriteLine("5. feladat:");
var organizations = prizes.Where(p => p.Year >= 1990 && p.Type == "béke" && string.IsNullOrEmpty(p.LastName));
foreach (var org in organizations)
{
    Console.WriteLine($"\t{org.Year}: {org.FirstName}");
}

Console.WriteLine("6. feladat:");
var curieFamily = prizes.Where(p => p.LastName.Contains("Curie") || p.FirstName.Contains("Curie"));
foreach (var member in curieFamily)
{
    Console.WriteLine($"\t{member.Year}: {member.FirstName} {member.LastName} ({member.Type})");
}

Console.WriteLine("7. feladat:");
var statistics = prizes.GroupBy(p => p.Type);
foreach (var stat in statistics)
{
    Console.WriteLine($"\t{stat.Key,-20} {stat.Count()} db");
}

var medicalPrizes = prizes
    .Where(p => p.Type == "orvosi")
    .OrderBy(p => p.Year)
    .Select(p => $"{p.Year}:{p.FirstName} {p.LastName}");

File.WriteAllLines("orvosi.txt", medicalPrizes, Encoding.UTF8);
Console.WriteLine("8. feladat: orvosi.txt");

Console.ReadKey();
