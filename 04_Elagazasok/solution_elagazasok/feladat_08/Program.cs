Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

if (number1 % 4 == 0 && number1 % 6 == 0)
{
    Console.WriteLine("A szám osztható 4-el és 6-al.");
}
else
{
    Console.WriteLine("A szám nem osztható 4-el és 6-al.");
}

