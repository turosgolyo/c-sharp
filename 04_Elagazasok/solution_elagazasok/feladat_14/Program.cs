Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number3 = int.Parse(Console.ReadLine());

if ((number1 % number2 == 0)&&(number1 % number3 == 0))
{
    Console.WriteLine($"Az első szám osztható a másodikkal, és a harmadik számmal.");
}
else if (number1 % number2 == 0)
{
    Console.WriteLine("Az első szám osztható a második számmal.");
}
else if (number1 % number3 == 0)
{
    Console.WriteLine("Az első szám osztható a harmadik számmal.");
}
else
{
    Console.WriteLine("Az első szám egyikkel se osztható.");
}
