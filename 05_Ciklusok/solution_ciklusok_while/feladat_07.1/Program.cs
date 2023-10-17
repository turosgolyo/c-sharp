int numberSmall = 0;
int numberBig = 0;
string input = "";
bool isNumber1 = false;
bool isNumber2 = false;

do
{
    Console.Write("Adjon meg egy számot: ");
    input = Console.ReadLine();
    isNumber1 = int.TryParse(input, out numberSmall);
    if (!isNumber1)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
    Console.Write("Adjon meg egy nagyobb számot: ");
    input = Console.ReadLine();
    isNumber2 = int.TryParse(input, out numberBig);
    if (!isNumber2)
    {
        Console.WriteLine("Nem számot adott meg!");
    }
}
while ((numberSmall >= numberBig) || !isNumber1 || !isNumber2);

do
{
    Console.WriteLine(numberBig);
    numberBig--;
}
while (numberSmall <= numberBig);

Console.ReadKey();