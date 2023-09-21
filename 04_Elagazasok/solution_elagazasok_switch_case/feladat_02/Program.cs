Console.WriteLine("Melyik hónap?");
string month = Console.ReadLine();

int monthIndex = month switch
{
    "Január" => 1,
    "Február" => 2,
    "Március" => 3,
    "Április" => 4,
    "Május" => 5,
    "Június" => 6,
    "Július" => 7,
    "Augusztus" => 8,
    "Szeptembet" => 9,
    "Október" => 10,
    "November" => 11,
    "December" => 12,
    _ => 0
};
switch (monthIndex)
{
    case 0:
        Console.WriteLine("Ilyen hónap nincs");
        break;
    default:
        Console.WriteLine(monthIndex);
        break;
}