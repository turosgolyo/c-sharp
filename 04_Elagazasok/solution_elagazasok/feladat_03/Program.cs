Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if ((number > -30) && (number < 40))
{
    Console.WriteLine("A szám -30 és 40 között van.");
}
else
{
    Console.WriteLine("A szám nincs -30 és 40 között.");
}
