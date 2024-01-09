public class Car
{
    public string Plate { get; set; }
    public double Refuel { get; set; }
    public Car(string plate, double refuel)
    {
        Plate = plate;
        Refuel = refuel;
    }
    public override string ToString()
    {
        return $"{Plate} - {Refuel} liter.";
    }
}
