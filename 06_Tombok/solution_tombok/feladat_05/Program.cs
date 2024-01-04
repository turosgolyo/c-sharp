using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_CARS = 2;

Car[] cars = GetCars();


Console.WriteLine("\nAutók adatai:");
PrintCarsOnConsole(cars);

int distributedFines = cars.Sum(x => x.Fine);
Console.WriteLine($"\nAz összes kiosztott büntetés: {distributedFines} Ft.");

int fastestCarSpeed = cars.Max(x => x.Speed);
Car fastestCar = cars.First(x => x.Speed == fastestCarSpeed);

Console.WriteLine($"\nLeggyorsabb autó:\n{fastestCar}");

Console.WriteLine($"\nSzabályosan közlekedő autók:");
Car[] orderlyCars = GetOrderlyCars(cars);
PrintCarsOnConsole(orderlyCars);

int orderlyCarsCount = cars.Count(x => x.Fine == 0);
double orderlyCarsAverage = ((double)orderlyCarsCount / NUMBER_OF_CARS) * 100;
Console.WriteLine($"\nSzabályosan közlekedő autók százaléka: {orderlyCarsAverage}%");


Car[] GetCars()
{
    Car[] cars = new Car[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string plate = ExtendedConsole.ReadString($"Adja meg az {i+1}. autó rendszámát!");
        int speed = ExtendedConsole.ReadInteger($"Adja meg az {i+1}. autó sebességét!");
        int fine = GetFine(speed);

        cars[i] = new Car(plate, speed, fine);
    }
    return cars;
}
int GetFine(int speed)
{
    return speed switch
    {
        > 110 => 30000,
        > 100 => 20000,
        > 90 => 10000,
        _ => 0,
    };
}
void PrintCarsOnConsole(Car[] cars)
{
    foreach (Car car in cars)
    {
        Console.WriteLine(car);
    }
}
Car[] GetOrderlyCars(Car[] cars)
{
    int count = cars.Count(x => x.Fine == 0);
    Car[] orderlyCars = new Car[count];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        if (cars[i].Fine == 0)
        {
            string plate = cars[i].Plate;
            int speed = cars[i].Speed;
            int fine = cars[i].Fine;
            orderlyCars[i] = new Car(plate, speed, fine);
        } 
    }
    return cars;
}
