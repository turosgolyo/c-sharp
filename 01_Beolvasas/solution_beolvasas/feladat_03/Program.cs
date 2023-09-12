using System.Globalization;

Console.Write("Adja meg a nevét: ");

string name = Console.ReadLine();

Console.Write("Adja meg a magasságát méterben (m):");

double height = double.Parse(Console.ReadLine(), new CultureInfo("en-EN"));

Console.WriteLine($"{name} az ön magassága {height} m!");

Console.ReadKey();