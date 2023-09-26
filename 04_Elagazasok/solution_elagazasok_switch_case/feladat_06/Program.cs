Console.WriteLine("Adja meg az egyik oldal hosszát! ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Adja meg a másik oldal hosszát! ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Melyik értéket számolná ki?\nTerület - t\nKerület - k\nÁtló - a\n");
string solution = Console.ReadLine();
solution = solution.ToLower();

if (!((solution == "t") || (solution == "k") || (solution == "a")))
{
    Console.WriteLine("Ilyen érték nincsen.");
    return;
}
double result = solution switch
{
        "t" => number1 * number2,
        "k" => 2 * (number1 + number2),
        "a" => Math.Round(Math.Sqrt(Math.Pow(number1, 2) + Math.Pow(number2, 2)), 2),
        _ => 0
};
    switch (solution)
    {
        case "t":
            Console.WriteLine($"Az eredmény: {result} cm^2");
            break;
        default:
            Console.WriteLine($"Az eredmény: {result} cm");
            break;
    }