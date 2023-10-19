int start;
int end;
string temp;
bool isNumber;
int count = 0;

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
    if (i % 3 == 0 && i % 2 == 1)
    {
        count++;
    }
}

Console.WriteLine($"\nAz intervallumban a hárommal osztható számok amik nem párosak száma: {count}");
