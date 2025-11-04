using Solution.Volleyball;
using System.Text;

string[] allLines = await File.ReadAllLinesAsync("adatok.txt", Encoding.UTF7);
List<Player> players = new List<Player>();


foreach (string line in allLines)
{
    var data = line.Split('\t');
    var player = new Player
    {
        Name = data[0],
        Height = int.Parse(data[1]),
        Position = data[2],
        Nationality = data[3],
        Team = data[4],
        Country = data[5]
    };
    players.Add(player);
}

foreach(Player player in players)
{
    Console.WriteLine(player);
}
List<string> utok = players.Where(p => p.Position == "ütõ")
                           .Select(p => p.ToFullString())
                           .ToList();

await File.WriteAllLinesAsync("utok.txt", utok, Encoding.UTF8);

var groupedByTeam = players.GroupBy(p => p.Team);
foreach (var group in groupedByTeam)
{
    await File.AppendAllTextAsync("csapattagok.txt", $"\n{group.Key}: ", Encoding.UTF8);
    foreach (var player in group)
    {
        await File.AppendAllTextAsync("csapattagok.txt", $"{player.Name}, ", Encoding.UTF8);
    }
}

var sortedByHeight = players.OrderByDescending(p => p.Height)
                            .Select(p => p.ToFullString())
                            .ToList();

await File.WriteAllLinesAsync("magaslatok.txt", sortedByHeight, Encoding.UTF8);

var groupedByCountry = players.GroupBy(p => p.Country)
                              .Select(g => new { Country = g.Key, Count = g.Count() })
                              .ToList();

foreach(var group in groupedByCountry)
{
    await File.AppendAllTextAsync("nemzetisegek.txt", $"{group.Country}: {group.Count}\n", Encoding.UTF8);
}

var averageHeight = players.Average(p => p.Height);

var tallPlayers = players.Where(p => p.Height > averageHeight)
                         .Select(p => p.ToNameHeightString())
                         .ToList();
await File.WriteAllLinesAsync("atlagnalmagassabak.txt", tallPlayers, Encoding.UTF8);

var groupedByPosition = players.GroupBy(p => p.Position)
                              .Select(g => new { Position = g.Key, TotalHeight = g.Sum(p => p.Height) })
                              .OrderBy(g => g.TotalHeight)
                              .ToList();

var shortPlayers = players.Where(p => p.Height < averageHeight)
                          .Select(p => p.ToShorterThanAverageString(averageHeight))
                          .ToList();
await File.WriteAllLinesAsync("alacsonyak.txt", shortPlayers, Encoding.UTF8);


Console.ReadKey();