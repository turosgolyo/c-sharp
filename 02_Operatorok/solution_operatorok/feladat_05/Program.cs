Console.Write("Adja meg az első számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Adja meg a második számot! ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Adja meg a harmadik számot!! ");
double number3 = double.Parse(Console.ReadLine());

Console.Write("Adja meg a negyedik számot!! ");
double number4 = double.Parse(Console.ReadLine());

double solution = (number1 + number2) / (number3 - number4);
Console.WriteLine($"Az eredmény: {solution}");

Console.ReadKey();