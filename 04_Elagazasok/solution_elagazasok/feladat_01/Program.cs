Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("A szám nagyobb a nullánál");
}
else if (number == 0)
{
    Console.WriteLine("A szám nulla.");
}
else
{
    Console.WriteLine("A szám nem nagyobb nullánál");
}
