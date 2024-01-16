public class Player
{
    public string Name { get; set; }
    public int Points { get; set; }
    public Player(string name, int points)
    {
        this.Name = name;
        this.Points = points;
    }
    public override string ToString()
    {
        return $"Játékos neve: {Name} - Elért pontok száma: {Points}";
    }
}

