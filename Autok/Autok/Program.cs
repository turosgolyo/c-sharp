using Autok;
using System.Runtime.InteropServices;
using System.Text;

List<string> lines = File.ReadAllLines("autok.txt", Encoding.UTF8).ToList();
List<Car> cars = new List<Car>();

foreach (string line in lines)
{
    List<string> data = line.Split(' ').ToList();

    cars.Add(new Car
    {
        Day = int.Parse(data[0]),
        Time = data[1],
        LicensePlate = data[2],
        PersonId = int.Parse(data[3]),
        KmCounter = int.Parse(data[4]),
        InOrOutEntry = int.Parse(data[5]),
    });
}

Console.WriteLine("2. feladat");

int lastDay = cars.Where(x => x.InOrOutEntry == 0).Select(x => x.Day).Last();
string lastLicensePlate = cars.Where(x => x.InOrOutEntry == 0).Select(x => x.LicensePlate).Last();

Console.WriteLine($"{lastDay}. nap rendszám: {lastLicensePlate}");

Console.WriteLine("3. feladat");
Console.Write("Nap: ");

int day = int.Parse(Console.ReadLine());
List<Car> carsByDay = cars.Where(x => x.Day == day).ToList();

Console.WriteLine($"Forgalom a(z) {day}. napon:");
foreach (Car car in carsByDay)
{
    string inOrOut;
    if(car.InOrOutEntry == 1)
    {
        inOrOut = "be";
    } 
    else
    {
        inOrOut = "ki";

    }

    Console.WriteLine($"{car.Time} {car.LicensePlate} {car.PersonId} {inOrOut}");
}

Console.WriteLine("4. feladat");
List<Car> carsIn = cars.Where(x => x.InOrOutEntry == 1).ToList();
List<Car> carsOut = cars.Where(x => x.InOrOutEntry == 0).ToList();

int count = carsOut.Count() - carsIn.Count();
Console.WriteLine($"A hónap végén {count} autót nem hoztak vissza.");

Console.WriteLine("5. feladat");
var carsGroupedByLicensePlate = cars.GroupBy(x => x.LicensePlate);
List<CarByLicensePlate> carsByLicensePlates = new();
foreach(var group in carsGroupedByLicensePlate)
{
    carsByLicensePlates.Add(new CarByLicensePlate
    {
        LicensePlate = group.Key,
        KmCount = cars.Where(x => x.LicensePlate == group.Key).Select(x => x.KmCounter).Last() - cars.Where(x => x.LicensePlate == group.Key).Select(x => x.KmCounter).First()
    });
}

foreach(var car in carsByLicensePlates)
{
    Console.WriteLine(car.ToString());
}

Console.WriteLine("6. feladat");

Console.WriteLine("7. feladat");

Console.Write("Rendszám: ");
string licensePlate = Console.ReadLine();

var carsGroupedBy = cars.GroupBy(x => x.LicensePlate);

foreach(var car in carsGroupedBy)
{

}

