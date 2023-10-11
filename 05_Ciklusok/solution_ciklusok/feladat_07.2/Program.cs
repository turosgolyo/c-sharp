int numberSmall = 0;
int numberBig = 0;

while (numberSmall >= numberBig)
{
    Console.Write("Adjon meg egy számot: ");
    numberSmall = int.Parse(Console.ReadLine());

    Console.Write("Adjon meg egy nagyobb számot: ");
    numberBig = int.Parse(Console.ReadLine());
}


while (numberSmall <= numberBig)
{
    Console.WriteLine(numberBig);
    numberBig--;
}


Console.ReadKey();