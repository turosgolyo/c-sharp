public class Player
{
    public string Name { get; set; }
    public int Goals { get; set; }
    public Player(string name, int goals)
    {
        this.Name = name;
        this.Goals = goals;
    }

    public override string ToString()
    {
        return $"{Name} - {Goals} gól";
    }



}
