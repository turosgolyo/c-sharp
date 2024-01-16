using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_TRUCKS = 5;

Truck[] trucks = GetTrucks();

PrintTrucksToConsole(trucks);

double weightSum = SumWeight(trucks);
Console.WriteLine($"\nKamionok teljes súlya: {weightSum} tonna");

double weightAverage = AverageWeight(trucks);
Console.WriteLine($"\nKamionok átlag súlya: {weightSum} tonna");

Truck[] heaviestTrucks = GetHeaviestTrucks(trucks);
Console.WriteLine("\nLegnehezebb kamionok:");
PrintTrucksToConsole(heaviestTrucks);

Truck[] GetTrucks()
{
    Truck[] trucks = new Truck[NUMBER_OF_TRUCKS];
    for (int i = 0; i < NUMBER_OF_TRUCKS; i++)
    {
        string plate = ExtendedConsole.ReadString($"{i + 1} Rendszám:");

        trucks[i] = new Truck(plate);
    }
    return trucks;
}
Truck[] GetHeaviestTrucks(Truck[] trucks)
{
    double max = trucks.Max(x => x.Weight);
    Truck[] heaviestTrucks = trucks.Where(x => x.Weight == max).ToArray();
    return heaviestTrucks;
}
double SumWeight(Truck[] trucks) => trucks.Sum(x => x.Weight);
double AverageWeight(Truck[] trucks) => trucks.Average(x => x.Weight);


void PrintTrucksToConsole(Truck[] trucks)
{
    foreach( Truck truck in trucks)
    {
        Console.WriteLine(truck);
    }
}
