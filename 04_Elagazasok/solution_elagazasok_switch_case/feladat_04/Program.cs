Console.WriteLine("Adjon meg egy számot! ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Adjon meg egy másik számot! ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Adjon meg egy operátort! (+, -, *, /) ");
string op = Console.ReadLine();

if (!((op == "*") || (op == "/")  || (op == "+") || (op == "-")))
{
    Console.WriteLine("Ilyen operator nincsen.");
    return;
}

double result = op switch
{
    "+" => number1 + number2,
    "-" => number1 - number2,
    "*" => number1 * number2,
    "/" => number1 / number2,
    _ => 0
};
Console.WriteLine($"Az eredmény: {result}");
