Console.Write("Adj meg a film megjelenési évét: ");

int releaseYear = int.Parse(Console.ReadLine());

Console.Write("Adj meg a film rendező nevét: ");

string directorName = Console.ReadLine();

Console.Write("Adj meg a film címét: ");

string movieName = Console.ReadLine();

Console.Write("Adj meg a film főszereplőjét: ");

string leadActor = Console.ReadLine();

Console.WriteLine($"{releaseYear}-ban {directorName} rendezésében megjelent a/az {movieName} című film {leadActor} főszereplésével!");

Console.ReadKey();