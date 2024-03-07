public class Player
{
    public string Name { get; set; }
    public DateTime First { get; set; }
    public DateTime Last { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public double HeightInCentiMeters => Math.Round(Height * 2.54, 1);
    public Player(string name, DateTime first, DateTime last, int weight, int height)
    {
        Name = name;
        First = first;
        Last = last;
        Weight = weight;
        Height = height;
    }
    public Player()
    {
    }
    public override string ToString()
    {
        return $"{Name}, {First.Year}-{First.Month}-{First.Day}, {Last.Year}-{Last.Month}-{Last.Day}, {Weight}, {Height}";
    }
}