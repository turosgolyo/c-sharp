int number = 0;
bool isNumber = false;
string input = "";

do
{
    Console.Write("Adjon meg egy háromjegyű számot: ");
    input = Console.ReadLine();
    isNumber = int.TryParse(input, out number);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
}
while ((number > 999) || (number < 100) || !isNumber) ;

if (number % 7 == 0)
{
    Console.WriteLine("A szám osztható héttel.");
}
else
{
    Console.WriteLine("A szám nem osztható héttel.");
}

Console.ReadKey();