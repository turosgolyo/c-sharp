Console.Write("Adja meg a kedvenc autójának a márkáját: ");
string brand = Console.ReadLine();

Console.Write("Adja meg a kedvenc autójának a modelljét: ");
string modell = Console.ReadLine();

Console.Write("Adja meg a kedvenc autójának a típusát: ");
string type = Console.ReadLine();

Console.Write("Adja meg a kedvenc autójának a köbcentijét: ");
int cubic = int.Parse(Console.ReadLine());

Console.Write("Adja meg a kedvenc autójának a megjelenési évét: ");
int releaseYear = int.Parse(Console.ReadLine());

Console.WriteLine($"Márka: {brand}\nModell: {modell}\nTípus: {type}\nKöbcenti: {cubic}\nMegjelenési év: {releaseYear}");

Console.ReadKey();