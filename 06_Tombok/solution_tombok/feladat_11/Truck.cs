public class Truck
{
    public string Plate { get; set; }
    public double Weight { get; set; }

    public Truck(string plate, double weight)
    {
        Plate = plate;
        Weight = weight;
    }
    public override string ToString()
    {
        return $"Rendszám: {Plate} - Súly: {Weight} tonna";
    }
}