// 2 ember, nev, eletkor, suly, fekvo nyomas, melyik az erosebb? melyik osztalyba tartozik?

Person person1 = new Person();

    Console.WriteLine("Adja meg az első személy nevét: ");
    person1.PersonName = Console.ReadLine();

    Console.WriteLine("életkorát: ");
    person1.PersonAge = int.Parse(Console.ReadLine());

    Console.WriteLine("súlyát : ");
    person1.PersonWeight = double.Parse(Console.ReadLine());

    Console.WriteLine("fekvő nyomását: ");
    person1.PersonBenchPress = double.Parse(Console.ReadLine());

Person person2 = new Person();

    Console.WriteLine("Adja meg a második személy nevét: ");
    person2.PersonName = Console.ReadLine();

    Console.WriteLine("életkorát: ");
    person2.PersonAge = int.Parse(Console.ReadLine());

    Console.WriteLine("súlyát : ");
    person2.PersonWeight = double.Parse(Console.ReadLine());

    Console.WriteLine("fekvő nyomását: ");
    person2.PersonBenchPress = double.Parse(Console.ReadLine());

double power1 = person1.PersonBenchPress / person1.PersonWeight;

double power2 = person2.PersonBenchPress / person2.PersonWeight;

double stronger = 0;


if (power1 < power2)
{
    stronger = power2;
    Console.WriteLine($"A második személy erősebb ({power1})");
}
else if (power1 > power2)
{
    stronger = power1;
    Console.WriteLine($"Az első személy erősebb ({power1})");
}
else
{
    stronger = power2;
    Console.WriteLine($"A két személy ugyanolyan erős ({power1}, {power2})");
}

switch (stronger)
{
    case > 1:
        Console.WriteLine("Isten");
        break;
    case > 0.8:
        Console.WriteLine("Profi");
        break;
    case > 0.4:
        Console.WriteLine("Haladó");
        break;
    case > 0.2:
        Console.WriteLine("Kezdő");
        break;
    default:
        Console.WriteLine("Gyenge");
        break;
}