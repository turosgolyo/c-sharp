Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("A szám osztható a másik számmal.");
}
else
{
    Console.WriteLine("A szám nem osztható a másik számmal.");
}

