string name = string.Empty;

do
{
    Console.Write("Kérem adja meg a nevét: ");
    name = Console.ReadLine()
                  .Trim(); //levagja az ures szokozoket
}
while (name.Length < 2);


Console.WriteLine($"Üdvözlöm {name}");

Console.ReadKey();