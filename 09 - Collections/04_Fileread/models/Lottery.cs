
public class Lottery
{
    public string Name { get; set; }
    public List<int> Guesses { get; set; }
    public Lottery(string name, List<int> guesses)
    {
        Name = name;
        Guesses = guesses;
    }
    public Lottery() { }
    public override string ToString()
    {
        return $"{Name}\t{string.Join(",", Guesses)}";
    }
}
