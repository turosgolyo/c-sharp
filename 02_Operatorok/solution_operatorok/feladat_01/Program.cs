Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

int result = number1 + number2;
Console.Write($"A két szám összege: {result}");

Console.ReadKey();