using System.Globalization;

int age = 0;
bool isNumber = false;

while (!isNumber || age < 0 || age > 99)
{
    Console.Write("Adja meg életkorát: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out age);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg.");
    }
    else if (age < 0 || age > 99)
    {
        Console.WriteLine("A megadott ertek nincs a tartomanyban.");
    }
}


string ageGroup = "";

if (age <= 6)
{
    ageGroup = "gyerek";
}
else if (age <= 18)
{
    ageGroup = "iskolás";
}
else if (age <= 65)
{
    ageGroup = "dolgozó";
}
else
{
    ageGroup = "nyugdíjas";
}

Console.WriteLine($"A korosztály: {ageGroup}");

Console.ReadKey();