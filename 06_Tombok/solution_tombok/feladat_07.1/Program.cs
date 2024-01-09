using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_FRUITS = 2;

//1-2. feladat
Fruit[] fruits = GetFruits();
PrintFruitsToConsole(fruits);

//3. feladat
int priceSum = GetFruitsPriceSum(fruits);
Console.WriteLine($"\nAz összes gyümölcs ára: {priceSum} Ft.");

//4. feladat


Fruit[] GetFruits()
{
    Fruit[] fruits = new Fruit[NUMBER_OF_FRUITS];
    for (int i = 0; i < NUMBER_OF_FRUITS; i++)
    {
        string name = ExtendedConsole.ReadString($"Adja meg a(z) {i + 1}. gyümölcs nevét!");
        int amount = ExtendedConsole.ReadInteger($"Adja meg a gyümölcs mennyiségét kilógrammban!");
        int unitPrice = ExtendedConsole.ReadInteger($"Adja meg a gyümölcs egységárát!");

        fruits[i] = new Fruit(name, amount, unitPrice);
    }
    return fruits;
}
int GetFruitsPriceSum(Fruit[] fruits) => fruits.Sum(x => x.Price);
void PrintFruitsToConsole(Fruit[] fruits)
{
    foreach (Fruit fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
}