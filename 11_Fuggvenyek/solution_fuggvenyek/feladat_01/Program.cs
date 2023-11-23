using IOLibrary;

string name = ExtendedConsole.ReadString("Adja meg a nevét!");

int birthYear = ExtendedConsole.ReadInteger("Adja meg a születési évét!!", DateTime.Now.Year);

int age = CalculateAge(birthYear);

int CalculateAge(int birthYear) => DateTime.Now.Year - birthYear;

Console.WriteLine($"{name} ön {age} éves xd");

Console.ReadKey();