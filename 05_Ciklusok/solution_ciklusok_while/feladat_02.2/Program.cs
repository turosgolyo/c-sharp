string name = string.Empty;

while (name.Length < 2); //string.Empty <=> ""
{
    Console.Write("Kérem adja meg a nevét: ");
    name = Console.ReadLine()
                  .Trim(); //levagja az ures szokozoket
}

Console.WriteLine($"Üdvözlöm {name}");

Console.ReadKey();