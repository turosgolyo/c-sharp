int number = 0;
int sum = 0;

do
{
    Console.Write($"Jelenlegi összeg: {sum}. Adjon meg egy számot ");
    number = int.Parse(Console.ReadLine());
    sum += number;
}
while (sum <= 1000);

Console.WriteLine($"Az összeg ({sum}) meghaladta az ezret.");

Console.ReadKey();