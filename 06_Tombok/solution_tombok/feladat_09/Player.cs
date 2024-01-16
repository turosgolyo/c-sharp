public class Player
{
    public string Name { get; set; }
    public int Goals { get; set; }
    public Player(string name, int goals)
    {
        Name = name;
        Goals = goals;
    }
    public override string ToString()
    {
        return $"Játékos neve: {Name} - Gólok: {Goals}";
    }
}
