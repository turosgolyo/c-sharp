Random rnd = new Random();
int number = rnd.Next(0, 10);
int guess = 0;
int count = 0;

while (count != 5 && number != guess)
{
    count++;
    Console.Write($"{count}. próbálkozás. Adjon meg egy számot ");
    guess = int.Parse(Console.ReadLine());
}

if (number == guess)
{
    Console.WriteLine($"Eltalálta a számot. A szám {number} volt.");
}
else
{
    Console.WriteLine("Nem talált.");
}

Console.ReadKey();

