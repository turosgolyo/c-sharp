int number = 0;
int number2 = 0;
bool isNumber = false;
string input = "";
int sum = 0;
int count = 0;

do
{
    Console.Write("Adjon meg egy kétjegyű pozitív számot: ");
    input = Console.ReadLine();
    isNumber = int.TryParse(input, out number);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
} 
while ((number > 99) || (number < 10) || !isNumber);

do
{
Console.WriteLine(number2);
number2 = number2 + 2;
} 
while (number2 <= number);

number2 = 0;
do
{
    sum = sum + number2;
    number2 = number2 + 5;
}
while (number2 <= number);
Console.WriteLine($"Az 5-tel osztható számok összege: {sum}");

number2 = 0;
do
{
    number2 = number2 + 11;
    count++;
}
while (number2 < number);
Console.WriteLine($"A 11-el osztható számok száma: {count}");

number2 = 0;
do
{
    number2++;
    if(number2 % 7 == 3)
    {
        Console.WriteLine(number2);
    }
}
while (number2 < number);



Console.ReadKey();