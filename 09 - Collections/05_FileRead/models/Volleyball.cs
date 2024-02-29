public class Volleyball
{
    public string Name { get; set; }
    public List<int> Points { get; set; }
    public Volleyball(string name, List<int> points)
    {
        Name = name;
        Points = points;
    }
    public Volleyball()
    {
    }
}

