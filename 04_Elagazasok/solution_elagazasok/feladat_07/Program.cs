Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

if (number1 % 5 == 0)
{
    Console.WriteLine("A szám osztható 5-el.");
}
else
{
    Console.WriteLine("A szám nem osztható 5-el.");
}

