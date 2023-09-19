Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("A szám páros.");
}
else
{
    Console.WriteLine("A szám páratlan.");
}
if (number >= 0)
{
    Console.WriteLine("A szám pozitív.");
}
else
{
    Console.WriteLine("A szám negatív.");
}
if (number % 5 == 0)
{
    Console.WriteLine("A szám osztható 5-el.");
}
else
{
    Console.WriteLine("A szám nem osztható 5-el.");
}
