using CustomLibrary;
using IOLibrary;

//virag elso szama
int lowerLimit = MathFunctions.GenerateRandom(0, 9);
Console.WriteLine($"(Virág első száma {lowerLimit})");

//virag masodik szama
int upperLimit = MathFunctions.GenerateRandom(40, 50);
Console.WriteLine($"(Virág második száma {upperLimit})");

//generalt szam
int generatedNumber = MathFunctions.GenerateRandom(lowerLimit, upperLimit);
Console.WriteLine($"(Gép által generált szám {generatedNumber})");

//szam kitalalasa
int guessCount = GuessNumber(0, 50, generatedNumber);

//kiiras
Console.WriteLine($"Jázmin {guessCount} próbálkozás után találta el a számot.");


int GuessNumber(int lowerLimit,int upperLimit, int number)
{
    int count = 0;
    int guess = 0;
    do
    {
        count++;
        guess = ExtendedConsole.ReadInteger($"Találjon ki egy számot {lowerLimit} és {upperLimit} között!");
        Console.Write($"{count} - ");
        if (guess > number)
        {
            Console.WriteLine($"A szám kisebb mint {guess}");
        }
        else if (guess < number)
        {
            Console.WriteLine($"A szám nagyobb mint {guess}");
        }
        else
        {
            Console.WriteLine($"Eltalálta a számot ami {guess}.");
        }      
    } while (number != guess);
    return count;
}