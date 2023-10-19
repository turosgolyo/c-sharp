int start;
int end;
string temp;
bool isNumber;
int sumSeven = 0;
int sumFive = 0;

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
    if (i % 7 == 0)
    {
        sumSeven = sumSeven + i;
    }
    if (i % 5 == 0)
    {
        sumFive = sumFive + i;
    }
}

if (sumSeven > sumFive)
{
    Console.WriteLine($"\nAz intervallumban a HÉTTEL osztható számok összege (héttel: {sumSeven}, öttel: {sumFive}) a nagyobb.");
}
else
{
    Console.WriteLine($"\nAz intervallumban az ÖTTEL osztható számok összege (héttel: {sumSeven}, öttel: {sumFive}) a nagyobb.");
}