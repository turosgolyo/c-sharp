Console.Write("Adja meg a nevét: ");

string name = Console.ReadLine();

Console.Write("Adja meg a születési évét: ");

int birthYear = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} Ön {birthYear} született!");

Console.ReadKey();