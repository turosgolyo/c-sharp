﻿Console.Write("Adja meg az első számot! ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Adja meg a második számot! ");
double number2 = double.Parse(Console.ReadLine());

Console.Write("Adja meg a harmadik számot!! ");
int number3 = int.Parse(Console.ReadLine());

double result = Math.Round((number1 * number2) / number3, 2);
Console.WriteLine($"Az eredmény: {result}");

Console.ReadKey();