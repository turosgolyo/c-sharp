using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_TRUCKS = 5;

Truck[] trucks = GetTrucks();

PrintTrucksToConsole(trucks);

double weightSum = SumWeight(trucks);
Console.WriteLine($"\nKamionok teljes súlya: {weightSum} tonna");

double weightAverage = AverageWeight(trucks);
Console.WriteLine($"\nKamionok átlag súlya: {weightAverage} tonna");

Truck[] heaviestTrucks = GetHeaviestTrucks(trucks);
Console.WriteLine("\nLegnehezebb kamionok:");
PrintTrucksToConsole(heaviestTrucks);

bool isTruck = IsTruck10Tons(trucks);
Console.WriteLine($"\n10 tonnás kamion: {(isTruck ? "Volt" : "Nem volt")}");

Truck[] trucksOver = GetTrucksOver10Tons(trucks);
Console.WriteLine($"\nKamionok 10 tonna felett:");
PrintTrucksPlateToConsole(trucksOver);

int lightestTruckNumber = GetLightestTruckNumber(trucks);
Console.WriteLine($"\nLegkönnyebb kamion a(z) {lightestTruckNumber}.");

Truck[] GetTrucks()
{
    Truck[] trucks = new Truck[NUMBER_OF_TRUCKS];
    for (int i = 0; i < NUMBER_OF_TRUCKS; i++)
    {
        string plate = ExtendedConsole.ReadString($"{i + 1} Rendszám:");

        trucks[i] = new Truck(plate, Math.Round(NextDouble(3.5, 40), 2));
    }
    return trucks;
}
Truck[] GetHeaviestTrucks(Truck[] trucks)
{
    double max = trucks.Max(x => x.Weight);
    Truck[] heaviestTrucks = trucks.Where(x => x.Weight == (double)max).ToArray();
    return heaviestTrucks;
}
double SumWeight(Truck[] trucks) => trucks.Sum(x => x.Weight);
double AverageWeight(Truck[] trucks) => trucks.Average(x => x.Weight);
bool IsTruck10Tons(Truck[] trucks) => trucks.Any(x => x.Weight == 10);
Truck[] GetTrucksOver10Tons(Truck[] trucks) => trucks.Where(x => x.Weight > 10).ToArray();
int GetLightestTruckNumber(Truck[] trucks)
{
    int i = 0;
    double min = trucks.Min(x => x.Weight);
    foreach(Truck truck in trucks)
    {
        i++;
        if(truck.Weight == min)
        {
            break;
        }
    }
    return i;
}
void PrintTrucksToConsole(Truck[] trucks)
{
    foreach(Truck truck in trucks)
    {
        Console.WriteLine(truck);
    }
}
void PrintTrucksPlateToConsole(Truck[] trucks)
{
    foreach (Truck truck in trucks)
    {
        Console.WriteLine(truck.Plate);
    }
}
double NextDouble(double min, double max)
{
    Random random = new Random();
    double value = random.NextDouble() * (max - min) + min;
    return (double)value;
}