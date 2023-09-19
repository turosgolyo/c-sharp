Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if ((number >= 0) && (number < 10))
{
    Console.WriteLine("A szám egyjegyű");
}
else if ((number >= 10) && (number < 100))
{
    Console.WriteLine("A szám kétjegyű");
}
else if ((number >= 100) && (number < 1000))
{
    Console.WriteLine("A szám háromjegyű");
}
else
{
    Console.WriteLine("A szám háromjegyűnél nagyobb");
}