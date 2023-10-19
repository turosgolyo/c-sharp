int start;
int end;
string temp;
bool isNumber;
int sumFirst = 0;
int sumSecond = 0;
int result;

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

for (int i = start; i < end; i = i + 2)
{
    Console.Write($"{i} ");
    sumFirst = sumFirst + i;
}
for (int i = start+1; i < end; i = i + 2)
{
    Console.Write($"{i} ");
    sumSecond = sumSecond + i;
}

result = sumFirst - sumSecond;

Console.WriteLine($"\nAz eredmény: {result} (első: {sumFirst}, második: {sumSecond})");