public class PlayerTeams
{
    public string TeamName { get; set; }
    public string PlayerName { get; set; }
    public PlayerTeams()
    {
    }
    public PlayerTeams(string teamName, int playerName)
    {
        TeamName = teamName;
        PlayerName = playerName;
    }
}
