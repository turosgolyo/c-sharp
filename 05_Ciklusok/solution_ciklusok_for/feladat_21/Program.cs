int rows = 0;
int space = 0;
int number = 0;

Console.WriteLine("Adja meg a számpiramis sorainak számát!");
rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    for (space = 1; space <= (rows - i); space++)
    {
        Console.Write("  ");
    }
    for (number = 1; number <= i; number++)
    {
        Console.Write(number);
        Console.Write(" ");
    }
    for (number = (i - 1); number >= 1; number--)
    {
        Console.Write(number);
        Console.Write(" ");
    }
    Console.WriteLine();
}