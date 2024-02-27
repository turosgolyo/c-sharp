public class PlayersByNation
{
    public string Nation { get; set; }
    public List<string> Names { get; set; }
    public PlayersByNation(string nation, List<string> names)
    {
        Nation = nation;
        Names = names;
    }
    public PlayersByNation() { }
}
