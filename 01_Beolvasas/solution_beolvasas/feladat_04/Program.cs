Console.Write("Adja meg a nevét: ");

string name = Console.ReadLine();

Console.Write("Nyomjon meg egy gombot: ");

char key = Console.ReadKey().KeyChar;

Console.WriteLine($"\n{name} ön a/az {key} billentyűt nyomta meg!");

Console.ReadKey();