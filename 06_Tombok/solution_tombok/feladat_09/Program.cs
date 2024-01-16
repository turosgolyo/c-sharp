using CustomLibrary.ConsoleExtensions;

const int NUMBER_OF_PLAYERS = 6;

Player[] players = GetPlayers();

PrintPlayersToConsole(players);

int playersBelowAverageCount = GetPlayersBelowAverageCount(players);
Console.WriteLine($"\nÁtlag alatt teljesítő játékosok száma: {playersBelowAverageCount}"); ;

Player[] playersAboveAverage = GetPlayersAboveAverage(players);
Console.WriteLine("\nÁtlag felett teljesítő játékosok:");
PrintPlayersToConsole(playersAboveAverage);

Player[] worstPlayers = GetWorstPlayers(players);
Console.WriteLine("\nLegkevesebb gól:");
PrintPlayersToConsole(worstPlayers);

Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];
    for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Játékos neve:");
        int goals = ExtendedConsole.ReadInteger("Gólok száma:");

        players[i] = new Player(name, goals);
    }
    return players;
}
int GetPlayersBelowAverageCount(Player[] players)
{
    double average = players.Average(x => x.Goals);
    int count = players.Count(x => x.Goals <= average);
    return count;
}
Player[] GetPlayersAboveAverage(Player[] players)
{
    double average = players.Average(x => x.Goals);
    Player[] playersAboveAverage = players.Where(x => x.Goals >= average).ToArray();
    return playersAboveAverage;
}
Player[] GetWorstPlayers(Player[] players)
{
    int min = players.Min(x => x.Goals);
    Player[] worstPlayers = players.Where(x => x.Goals == min).ToArray();
    return worstPlayers;
}
void PrintPlayersToConsole(Player[] players)
{
    foreach(Player player in players)
    {
        Console.WriteLine(player);
    }
}