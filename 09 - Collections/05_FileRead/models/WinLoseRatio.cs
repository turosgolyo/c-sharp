public class WinLoseRatio
{
    public string Name { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public WinLoseRatio(string name, int wins, int losses)
    {
        Name = name;
        Wins = wins;
        Losses = losses;
    }
    public WinLoseRatio()
    {
    }
}
