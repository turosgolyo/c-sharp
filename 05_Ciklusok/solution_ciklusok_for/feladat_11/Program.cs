﻿int start;
int end;
string temp;
bool isNumber;
int sum = 0;
int multiplication = 1;

do
{
    Console.WriteLine("Adjon meg egy kezdő értéket: ");
    temp = Console.ReadLine();
    isNumber = int.TryParse(temp, out start);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg.");
    }
}
while (!isNumber);

do
{
    Console.WriteLine("Adjon meg egy vég értéket (nagyobb): ");
    temp = Console.ReadLine();
    isNumber = int.TryParse(temp, out end);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg.");
    }
    else if (end <= start)
    {
        Console.WriteLine("Nagyobb számot adjon meg.");
    }
}
while (!isNumber || end <= start);

if (start % 2 == 1)
{
    for (int i = start + 1; i < end; i = i + 2)
    {
        Console.Write($"{i} ");
        sum = sum + i;
    }
}
else
{
    for (int i = start; i < end; i = i + 2)
    {
        Console.WriteLine($"{i} ");
        sum = sum + i;
    }
}

if (start % 2 == 1)
{
    for (int i = start; i < end; i = i + 2)
    {
        Console.Write($"{i} ");
        multiplication = multiplication * i;
    }
}
else
{
    for (int i = start + 1; i < end; i = i + 2)
    {
        Console.WriteLine($"{i} ");
        multiplication = multiplication * i;
    }
}

Console.WriteLine($"\nAz intervallum számainak összege: {sum}\nAz intervallum számainak szorzata: {multiplication}");

