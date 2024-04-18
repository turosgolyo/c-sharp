Console.WriteLine("Car drives uses his horn");
Car car = new Car();
//car.Horn();

await Task.Delay(1000);

Console.WriteLine("Truck drives uses his horn");
Truck truck = new Truck();
//truck.Horn();

await Task.Delay(1000);

//void SignalVehicleError(Truck truck)
//{
//    truck.Error();
//}
//void SignalVehicleError(Car car)
//{
//    car.Error();
//}

void SignalVehicleError(Vehicle vehicle)
{
    vehicle.Error();
}

SignalVehicleError(truck);