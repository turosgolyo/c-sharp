int numberSmall = 0;
int numberBig = 0;

do
{
    Console.Write("Adjon meg egy számot: ");
    numberSmall = int.Parse(Console.ReadLine());

    Console.Write("Adjon meg egy nagyobb számot: ");
    numberBig = int.Parse(Console.ReadLine());
}
while (numberSmall >= numberBig);

do
{
    Console.WriteLine(numberBig);
    numberBig--;
}
while (numberSmall <= numberBig);

Console.ReadKey();