public class PlayersByTeam
{
    public string TeamName { get; set; }
    public List<string> Players { get; set; }
    public PlayersByTeam(string teamName, List<string> players)
    {
        TeamName = teamName;
        Players = players;
    }

    public PlayersByTeam() { }
}

