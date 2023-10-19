int start;
int end;
string temp;
bool isNumber;
int sumEven = 0;
int sumOdd = 0;

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
        sumEven = sumEven + i;
    }
}
else
{
    for (int i = start; i < end; i = i + 2)
    {
        Console.WriteLine($"{i} ");
        sumEven = sumEven + i;
    }
}

if (start % 2 == 1)
{
    for (int i = start; i < end; i = i + 2)
    {
        Console.Write($"{i} ");
        sumOdd = sumOdd + i;
    }
}
else
{
    for (int i = start + 1; i < end; i = i + 2)
    {
        Console.WriteLine($"{i} ");
        sumOdd = sumOdd + i;
    }
}

if(sumOdd > sumEven)
{
    Console.WriteLine($"\nAz intervallumban a PÁRATLAN számok összege (páratlan: {sumOdd}, páros: {sumEven}) a nagyobb.");
}
else
{
    Console.WriteLine($"\nAz intervallumban a PÁROS számok összege (páratlan: {sumOdd}, páros: {sumEven}) a nagyobb.");
}
