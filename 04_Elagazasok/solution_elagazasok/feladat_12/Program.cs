Console.Write("Adjon meg egy számot! ");
int number = int.Parse(Console.ReadLine());

if ((number > 10)&&(number < 20))
{
    Console.WriteLine("A szám 10 és 20 között van.");
}
else if ((number > -20) && (number < -10))
{
    Console.WriteLine("A szám -20 és -10 között van.");
}
else
{
    Console.WriteLine("A szám nincs -20 és -10 között, se 10 és 20 között.");
}