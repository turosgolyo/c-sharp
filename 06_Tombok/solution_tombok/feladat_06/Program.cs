using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_CARS = 2;

Car[] cars = GetCars();

//0. feladat
Console.WriteLine("\nAutók adatai:");
PrintCarsOnConsole(cars);

//1. feladat
Car[] over40Liters = GetCarsOver40Liters(cars);
Console.WriteLine("\n40 liter felett tankolt autók:");
PrintCarsOnConsole(over40Liters);

//2. feladat
double FuelSum = GetFuelSum(cars);
Console.WriteLine($"\nÖsszesen tankolt üzemanyag: {FuelSum} liter");

//3. feladat
Car[] mostRefueledCars = RefueledTheMost(cars);
Console.WriteLine($"\nLegtöbbet tankolt autók:");
PrintCarsOnConsole(mostRefueledCars);

//4. feladat
Car[] leastRefueledCars = RefueledTheLeast(cars);
Console.WriteLine($"\nLegkevesebbet tankolt autók:");
PrintCarsOnConsole(leastRefueledCars);

//5. feladat
int carsCountUnder30Liters = CountCarsUnder30Liters(cars);
Console.WriteLine($"\n30 liter alatt tankolt autók száma: {carsCountUnder30Liters}.");

//6. feladat
bool over50Liters = IsOver50Liters(cars);
Console.WriteLine($"\n50 liter felett tankolt autó: {(over50Liters ? "Volt" : "Nem volt")}");

Car[] GetCars()
{
    Car[] cars = new Car[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string plate = ExtendedConsole.ReadString($"Adja meg az {i + 1}. autó rendszámát!");
        double refuel = ExtendedConsole.ReadDouble($"Adja meg a tankolt mennyiséget literben!");

        cars[i] = new Car(plate, refuel);
    }
    return cars;
}
Car[] GetCarsOver40Liters(Car[] cars) => cars.Where(x => x.Refuel > 40).ToArray();
double GetFuelSum(Car[] cars) => cars.Sum(x => x.Refuel);
Car[] RefueledTheMost(Car[] cars)
{
    double maxRefuel = cars.Max(x => x.Refuel);
    Car[] mostRefueledCar = cars.Where(x => x.Refuel == maxRefuel).ToArray();
    return mostRefueledCar;
}
Car[] RefueledTheLeast(Car[] cars)
{
    double minRefuel = cars.Min(x => x.Refuel);
    Car[] leastRefueledCar = cars.Where(x => x.Refuel == minRefuel).ToArray();
    return leastRefueledCar;
}
bool IsOver50Liters(Car[] cars) => cars.Any(x => x.Refuel > 50);
int CountCarsUnder30Liters(Car[] cars) => cars.Count(x => x.Refuel < 30);
void PrintCarsOnConsole(Car[] cars)
{
    foreach(Car car in cars)
    {
        Console.WriteLine(car);
    }
}