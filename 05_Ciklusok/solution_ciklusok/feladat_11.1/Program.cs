int numberEven = 0;
int numberOdd = 0;

do
{
    Console.Write("Adjon meg egy páros számot: ");
    numberEven = int.Parse(Console.ReadLine());

    Console.Write("Adjon meg egy páratlan számot: ");
    numberOdd = int.Parse(Console.ReadLine());
}
while ((numberEven % 2 == 1) && (numberOdd % 2 == 0) && (numberEven > numberOdd));

Console.ReadKey();