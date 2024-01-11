using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_FRUITS = 2;

//1-2. feladat
Fruit[] fruits = GetFruits();
PrintFruitsToConsole(fruits);

//3. feladat
int priceSum = GetFruitsPriceSum(fruits);
Console.WriteLine($"\nAz összes gyümölcs ára: {priceSum} Ft.");

//4. feladat
Fruit mostExpensiveFruit = GetMostExpensiveFruit(fruits);
Console.WriteLine($"\nLegdrágább gyümölcs neve és egység ára:\n{mostExpensiveFruit.Name} - {mostExpensiveFruit.UnitPrice} Ft/kg");

//5. feladat
Console.WriteLine("\nLegkevesebb gyümölcs:");
Fruit[] leastAmountFruits = GetLeastAmountFruits(fruits);
PrintFruitsToConsole(leastAmountFruits);

//6. feladat
Console.WriteLine("\nGyümölcsök 100 kilogramm alatt:");
Fruit[] fruitsUnder100kg = GetFruitsUnder100kg(fruits);
PrintFruitsToConsole(fruitsUnder100kg);

//7. feladat
bool over1500 = IsPriceOver1500(fruits);
Console.WriteLine($"\n1500 Ft feletti egységárú gyümölcs: {(over1500? "Volt" : "Nem volt")}");

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
Fruit GetMostExpensiveFruit(Fruit[] fruits)
{
    double maxPrice = fruits.Max(x => x.UnitPrice);
    Fruit mostExpensiveFruit = fruits.First(x => x.UnitPrice == maxPrice);
    return mostExpensiveFruit;
}
Fruit[] GetLeastAmountFruits(Fruit[] fruits)
{
    double minAmount = fruits.Min(x => x.Amount);
    Fruit[] leastAmountFruits = fruits.Where(x => x.Amount == minAmount).ToArray();
    return leastAmountFruits;
}
Fruit[] GetFruitsUnder100kg(Fruit[] fruits) => fruits.Where(x => x.Amount < 100).ToArray();
bool IsPriceOver1500(Fruit[] fruits) => fruits.Any(x => x.UnitPrice > 1500);
void PrintFruitsToConsole(Fruit[] fruits)
{
    foreach (Fruit fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
}