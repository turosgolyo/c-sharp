int number = 0;
int sum = 0;
int limit = 0;

do
{
    Console.Write("Adjon meg egy határértéket (min. 100)! ");
    limit = int.Parse(Console.ReadLine());
}
while (100 >= limit);

do
{
    Console.Write($"Jelenlegi összeg: {sum}. Adjon meg egy számot ");
    number = int.Parse(Console.ReadLine());
    sum += number;
}
while (sum <= 1000);

Console.WriteLine($"Az összeg ({sum}) meghaladta az ezret.");

Console.ReadKey();