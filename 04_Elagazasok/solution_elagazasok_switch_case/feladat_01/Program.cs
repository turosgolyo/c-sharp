Console.WriteLine("Ma hanyadik napja van a hétnek?");
int weekDay = int.Parse(Console.ReadLine());

switch (weekDay)
{
    case 1:
        Console.WriteLine("Hétfő");
        break;
    case 2:
        Console.WriteLine("Kedd");
        break;
    case 3:
        Console.WriteLine("Szerda");
        break;
    case 4:
        Console.WriteLine("Csütörtök");
        break;
    case 5:
        Console.WriteLine("Péntek");
        break;
    case 6:
        Console.WriteLine("Szombat");
        break;
    case 7:
        Console.WriteLine("Vasárnap");
        break;
    default:
        Console.WriteLine("Ilyen nap nem is letezik");
        break;
}