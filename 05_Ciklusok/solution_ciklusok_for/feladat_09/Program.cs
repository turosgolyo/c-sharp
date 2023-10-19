int start;
int end;
string temp;
bool isNumber;

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
    Console.WriteLine("Adjon meg egy vég értéket (kisebb): ");
    temp = Console.ReadLine();
    isNumber = int.TryParse(temp, out end);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg.");
    }
    else if (end >= start)
    {
        Console.WriteLine("Kisebb számot adjon meg.");
    }
}
while (!isNumber || end >= start);

Console.WriteLine("Csökkenő sorrendben páros számok:");

if (start % 2 == 1)
{
    start--;
}

for (int i = start; i > end; i = i - 2)
{
    Console.Write($"{i} ");
}

