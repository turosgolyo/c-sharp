using Microsoft.Win32.SafeHandles;

int start;
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

for (int i = start; i < end; i++)
{
    Console.Write($"{i} ");
    if(i % 2 == 0)
    {
        sum = sum + i;
    }
    else
    {
        multiplication = multiplication * i;
    }
}

Console.WriteLine($"\nAz intervallum számainak összege: {sum}\nAz intervallum számainak szorzata: {multiplication}");

