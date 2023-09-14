Console.Write("Adja meg az első számot! ");
double number1 = double.Parse(Console.ReadLine());

number1 = number1 + 0.5;

Console.Write("Adja meg a második számot! ");
double number2 = double.Parse(Console.ReadLine());

number2 = number2 - 0.7;

double result1 = number1 * number2;

Console.Write("Adja meg a harmadik számot!! ");
double number3 = double.Parse(Console.ReadLine());

double result2 = Math.Round(result1 % number3, 2);
Console.WriteLine($"Az eredmény: {result2}");

Console.ReadKey();