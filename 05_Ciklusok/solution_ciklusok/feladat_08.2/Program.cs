int choice = 0;

while ((choice <= 0) || (choice > 4))
{
    Console.WriteLine("Válasszon az üdítők közül:\nCoca Cola - 1\nPepsi - 2\nFanta - 3\nSprite - 4");

    choice = int.Parse(Console.ReadLine());

    string drink = choice switch
    {
        1 => "Ön a Coca Cola-t választotta",
        2 => "Ön a Pepsi-t választotta",
        3 => "Ön a Fanta-t választotta",
        4 => "Ön a Sprite-t választotta",
        _ => "Ilyen nincs xd"
    };
    Console.WriteLine(drink);
}