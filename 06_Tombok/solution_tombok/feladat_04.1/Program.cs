using CustomLibrary.ConsoleExtensions;
using System.Linq;

const int PLAYERS = 3;

Player[] players = GetPlayer();

Console.WriteLine("Játékosok:");
PrintPlayersOnConsole(players);

Console.WriteLine("Átlag alatt teljesítő játékosok:");
Player[] playersBelowAvarage = players.Where(x => x.Goals < average).ToArray();
PrintPlayersOnConsole(playersBelowAvarage);

double average = players.Average(x => x.Goals);
int aboveAveragePlayerCount = AbovePerformancePlayerCount(players, average);
Console.Write($"Átlag felett teljesítő játékosok száma: {aboveAveragePlayerCount} fő");

int bestPlayer = players;

Console.ReadKey();

Player[] GetPlayer()
{
    Player[] players = new Player[PLAYERS];

    for (int i = 0; i < PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a játékos nevét!");
        int goals = ExtendedConsole.ReadInteger("Adja meg a játékos góljainak számát!");

        players[i] = new Player(name, goals);
    }

    return players;
}
int AbovePerformancePlayerCount(Player[] players, double average)
{
    int count = 0;
    foreach (Player player in players)
    {
        if (player.Goals >= average)
        {
            count++;
        }         
    }
    return count;
}
void PrintPlayersOnConsole(Player[] players)
{
    foreach (Player player in players)
    {
        Console.WriteLine(player);
    }
}

int GetMaxGoals(Player[] players)
{
;
}
