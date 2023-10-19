int start;
int end;
string temp;
bool isNumber;
int sum = 0;
double count = 0;
double average;

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

for(int i = start; i < end; i++)
{
    Console.WriteLine(i);
    count++;
    sum = sum + i;
}
average = sum / count;

Console.WriteLine($"A páros és a páratlan számok átlaga: {average}");
