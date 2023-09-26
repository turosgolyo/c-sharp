Console.WriteLine("Adja meg az egyik ellenállást! ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Adja meg a másik ellenállást! ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Soros vagy párhuzamos?! (P, S) ");
string connection = Console.ReadLine();
connection = connection.ToLower();

if (!((connection == "p") || (connection == "s")))
{
    Console.WriteLine("Ilyen kapcsolás nincsen.");
    return;
}

double result = connection switch
{
    "p" => (number1 + number2) / (number1 * number2),
    "s" => number1 + number2,
    _ => 0
};
Console.WriteLine($"Az eredmény: {result} ohm");