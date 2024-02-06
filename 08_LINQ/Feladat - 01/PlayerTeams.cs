using System.Collections.Generic;
using System.Text;

public class PlayerTeams
{
    public string TeamName { get; set; }
    public List<string> PlayerNames { get; set; }
    public PlayerTeams()
    {
    }
    public PlayerTeams(string teamName, List<string> playerNames)
    {
        TeamName = teamName;
        PlayerNames = playerNames;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(TeamName);

        foreach(string player in PlayerNames)
        {
            sb.AppendLine($"\t-{player}");
        }

        return sb.ToString();
    }
}
