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

for (int i = start; i < end; i++)
{
    Console.Write($"{i} ");
    if (i % 2 == 0)
    {
        sumEven += i;
    }
    else
    {
        sumOdd += i;
    }
}

if (sumOdd > sumEven)
{
    Console.WriteLine($"\nAz intervallumban a PÁRATLAN számok összege (páratlan: {sumOdd}, páros: {sumEven}) a nagyobb.");
}
else
{
    Console.WriteLine($"\nAz intervallumban a PÁROS számok összege (páratlan: {sumOdd}, páros: {sumEven}) a nagyobb.");
}
