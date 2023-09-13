Console.Write("Adja meg az első számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adja meg a második számot! ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Adja meg a harmadik számot!! ");
int number3 = int.Parse(Console.ReadLine());

int solution = (number1 * number2) / number3;
Console.WriteLine($"Az eredmény: {solution}");

Console.ReadKey();