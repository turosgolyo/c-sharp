string input = "";
bool isNumber1 = false;
bool isNumber2 = false;
int numberEven = 0;
int numberOdd = 0;
int numberEvenDist = 0;
int numberOddDist = 0;
double count = 0;
int temp = 0;
int sum = 0;
double average = 0;

do
{
    Console.Write("Adjon meg egy páros számot: ");
    input = Console.ReadLine();
    isNumber1 = int.TryParse(input, out numberEven);
    if (!isNumber1)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
    Console.Write("Adjon meg egy páratlan számot: ");
    input = Console.ReadLine();
    isNumber2 = int.TryParse(input, out numberOdd);
    if (!isNumber2)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
}
while ((numberEven % 2 == 1) || (numberOdd % 2 == 0) || (numberEven > numberOdd) || !isNumber1 || !isNumber2);

Random rnd = new Random();
int numberRand = rnd.Next(numberEven, numberOdd);

numberEvenDist = numberRand - numberEven;
numberOddDist = numberOdd - numberRand;

if(numberEvenDist < numberOddDist)
{
    Console.WriteLine($"A páratlan szám van messzebb a random számtól (random: {numberRand} páratlan: {numberOddDist}, páros: {numberEvenDist})");
}
else
{
    Console.WriteLine($"A páros szám van messzebb a random számtól (random: {numberRand} páratlan: {numberOddDist}, páros: {numberEvenDist})");
}

temp = numberEven;
do
{
    temp++;
    sum = sum + temp;
    count++;
}
while (numberOdd > temp);

average = sum / count;

Console.WriteLine($"Az átlag: {average}");

count = 0;
temp = numberEven;
Console.WriteLine("Héttel osztott számok amik 3-mat adnak maradékul.");
do
{
    ++count;
    if(temp % 7 == 3)
    {
        Console.WriteLine(temp);
    }
    temp++;
}
while (numberOdd > count);

Console.ReadKey();