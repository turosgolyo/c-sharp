
public class Hits
{
    public string Name { get; set; }
    public int HitsCount { get; set; }
    public Hits(string name, int hitsCount)
    {
        Name = name;
        HitsCount = hitsCount;
    }
    public Hits() { }
    public override string ToString()
    {
        return $"{Name}\t{HitsCount}";
    }
}
