int number = 0;
int sum = 0;
int limit = 1;

while (100 > limit)
{
    Console.Write("Adjon meg egy határértéket (min. 100)! ");
    limit = int.Parse(Console.ReadLine());
}


while (sum <= limit)
{
    Console.Write($"Jelenlegi összeg: {sum}. Adjon meg egy számot ");
    number = int.Parse(Console.ReadLine());
    sum += number;
}


Console.WriteLine($"Az összeg ({sum}) meghaladta a hatértéket ({limit}).");


Console.ReadKey();