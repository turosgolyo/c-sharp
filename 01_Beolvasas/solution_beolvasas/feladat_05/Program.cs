using System.Globalization;

Console.Write("Adja meg a kedvenc együttesének a nevét: ");

string bandName = Console.ReadLine();

Console.Write("Adja meg az együttes legjobb zeneszámát: ");

string songName = Console.ReadLine();

Console.Write("Adja meg a szám hosszát: ");

double songLength = double.Parse(Console.ReadLine(), new CultureInfo("en-EN"));

Console.WriteLine($"Az ön kedvenc együttesének {bandName} a legjobb zeneszáma {songName} melynek hossza {songLength} perc !");

Console.ReadKey();