// 1. feladat
using CustomLibrary.ConsoleExtensions;

List<Pair> pairs = await FileService.ReadFromFileAsync("tancrend.txt");
ExtendedSystem.WriteCollectionToConsole(pairs);

// 2. feladat
string firstDance = pairs.Select(x => x.Dance).First();
string lastDance = pairs.Select(x => x.Dance).Last();
Console.WriteLine($"Első tánc: {firstDance}");
Console.WriteLine($"Utolsó tánc: {lastDance}");


// 3. feladat
int sambaCount = pairs.Count(x => x.Dance == "samba");
Console.WriteLine($"Samba száma: {sambaCount}");

// 4. feladat
List<Pair> pairsWithVilma = pairs.Where(x => x.GirlName == "Vilma").ToList();
ExtendedSystem.WriteCollectionToConsole(pairsWithVilma);

// 5. feladat
string danceName = ExtendedConsole.ReadString("Tanc neve:");
List<Pair> dancesWithVilma = pairs.Where(x => x.GirlName == "Vilma" && x.Dance == danceName ).ToList();
if (dancesWithVilma.Count == 0)
{
    Console.WriteLine($"Vilma nem táncolt {danceName}-t.");
}
else
{
    foreach (Pair pair in dancesWithVilma)
    {
        Console.WriteLine($"A {danceName} bemutatóján Vilma párja {pair.BoyName} volt");
    };
}

// 6. feladat
List<string> boyNames = pairs.Select(x => x.BoyName).Distinct().ToList();
List<string> girlNames = pairs.Select(x => x.GirlName).Distinct().ToList();
await FileService.WriteToFileAsync("szereplok.txt", boyNames, girlNames);

//7. feladat
List<string> mostAppearedBoys = pairs.GroupBy(x => x.BoyName)
                                     .OrderByDescending(x => x.Count())
                                     .First()
                                     .Select(x => x.BoyName)
                                     .Distinct()
                                     .ToList();

List<string> mostAppearedGirls = pairs.GroupBy(x => x.GirlName)
                                      .OrderByDescending(x => x.Count())
                                      .First()
                                      .Select(x => x.BoyName)
                                      .Distinct()
                                      .ToList();

foreach (string name in mostAppearedBoys)
{
    Console.WriteLine($"A legtöbbet szerepelt fiú: {name}");
}
foreach (string name in mostAppearedGirls)
{
    Console.WriteLine($"A legtöbbet szerepelt lány: {name}");
}


