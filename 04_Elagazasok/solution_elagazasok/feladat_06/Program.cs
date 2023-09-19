Console.Write("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Adjon meg egy másik számot! ");
int number3 = int.Parse(Console.ReadLine());

if ((number1 > number2) && (number2 > number3))
{
    Console.WriteLine($"A sorrend: {number3}, {number2}, {number1}");
}
else if ((number2 > number1) && (number1 > number3))
{
    Console.WriteLine($"A sorrend: {number3}, {number1}, {number2}");
}
else if ((number3 > number1) && (number1 > number2))
{
    Console.WriteLine($"A sorrend: {number2}, {number1}, {number3}");
}
else if ((number3 > number2) && (number2 > number1))
{
    Console.WriteLine($"A sorrend: {number1}, {number2}, {number3}");
}
else if ((number2 > number3) && (number3 > number1))
{
    Console.WriteLine($"A sorrend: {number1}, {number3}, {number2}");
}
else if ((number1 > number3) && (number3 > number2))
{
    Console.WriteLine($"A sorrend: {number2}, {number3}, {number1}");
}
