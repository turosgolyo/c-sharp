Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if (number % 3 == 0 && number % 2 == 0)
{
    Console.WriteLine("ZIZI");
}
else if (number % 3 == 0)
{
    Console.WriteLine("BAZ");
}
else if (number % 2 == 0)
{
    Console.WriteLine("BIZ");
}
else
{
    Console.WriteLine("valami nem jo");
}


