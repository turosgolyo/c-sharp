public class Truck
{
    public string Plate { get; set; }
    public double Weight
    {
        get
        {
            double rnd = Math.Round(NextDouble(3.5, 40), 2);
            return rnd;
        }

    }
    public double NextDouble(double min, double max)
    {
        Random random = new Random();
        double value = random.NextDouble() * (max - min) + min;
        return (double)value;
    }
    public Truck(string plate)
    {
        Plate = plate;
    }
    public override string ToString()
    {
        return $"Rendszám: {Plate} - Súly: {Weight} tonna";
    }
}