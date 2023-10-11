int number = 0;

while ((number > 999) || (number < 100))
{
    Console.Write("Adjon meg egy számot: ");
    number = int.Parse(Console.ReadLine());
}


if (number % 7 == 0)
{
    Console.WriteLine("A szám osztható héttel.");
}
else
{
    Console.WriteLine("A szám nem osztható héttel.");
}

Console.ReadKey();