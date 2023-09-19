Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"A nagyobb szám: {number1}");
}
else
{
    Console.WriteLine($"A nagyobb szám {number2}");
}
