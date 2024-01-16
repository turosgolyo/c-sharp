using CustomLibrary.ConsoleExtensions;
const int NUMBER_OF_PLAYERS = 5;

Player[] players = GetPlayers();

PrintPlayersToConsole(players);

int allPoints = GetPointsSum(players);
Console.WriteLine($"\nSzezonban elért pontszám: {allPoints}");

Player[] bestPlayers = GetBestPlayers(players);
Console.WriteLine("\nLegtöbb pontot elért játékosok:");
PrintPlayersToConsole(bestPlayers);

Player[] worstPlayers = GetWorstPlayers(players);
Console.WriteLine("\nLegkevesebb pontot elért játékosok:");
PrintPlayersToConsole(worstPlayers);

int playersBelowAverageCount = GetPlayersBelowAverageCount(players);
Console.WriteLine($"\nÁtlag alatti játékosok száma: {playersBelowAverageCount}");

Player[] playersAboveAverage = GetPlayersAboveAverage(players);
Console.WriteLine("\nÁtlag feletti játékosok:");
PrintPlayersToConsole(playersAboveAverage);



Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];
    for(int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Játkos neve:");
        int points = ExtendedConsole.ReadInteger("Elért pontszám:");

        players[i] = new Player(name, points);
    }
    return players;
}
int GetPointsSum(Player[] players) => players.Sum(x => x.Points);
Player[] GetBestPlayers(Player[] players)
{
    int maxPoints = players.Max(x => x.Points);
    Player[] bestPlayers = players.Where(x => x.Points == maxPoints).ToArray();
    return bestPlayers;
}
Player[] GetWorstPlayers(Player[] players)
{
    int minPoints = players.Min(x => x.Points);
    Player[] worstPlayers = players.Where(x => x.Points == minPoints).ToArray();
    return worstPlayers;
}
int GetPlayersBelowAverageCount(Player[] players)
{
    double average = players.Average(x => x.Points);
    int count = players.Count(x => x.Points <= average);
    return count;
}
Player[] GetPlayersAboveAverage(Player[] players)
{
    double average = players.Average(x => x.Points);
    Player[] playersAboveAverage = players.Where(x => x.Points >= average).ToArray();
    return playersAboveAverage;
}
void PrintPlayersToConsole(Player[] players)
{
    foreach(Player player in players)
    {
        Console.WriteLine(player);
    }
}