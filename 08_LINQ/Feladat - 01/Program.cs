using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Feladat___01
{
    internal class Program
    {
        private static List<Player> _players = new List<Player>();

        private static void LoadData()
        {
            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _players = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Player> players)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _players));
        }

        private static void WriteToConsole(string text, Player player)
        {
            Console.WriteLine(text);
            Console.WriteLine(player);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole("Data", _players);
            
            // 1. hany jatekos van az adatbazisban?
            int playerCount = _players.Count;

            // 2. hatarozzuk meg az atlagmagassagot
            double averageHeight = _players.Average(x => x.Height);

            // 3. legalacsonyabb jatekos neve
            string shortestPlayerName = _players.MinBy(x => x.Height).Name;

            // 4. 1980-as szuletesu jatekosok
            List<Player> playersBornIn1980 = _players.Where(x => int.Parse(x.Birthday.Split('.')[0]) == 1980).ToList();

            // 5. rendezzuk a jatekosokat nev szerint csokkeno sorrenbe es magassag szerint novekvo sorrendbe
            List<Player> sortedPlayersByNameAndHeight = _players.OrderByDescending(x => x.Name)
                                                                .ThenByDescending(x => x.Height)
                                                                .ToList();

            // 6. keressuk ki hogy posztonkent hany jatekosunk van
            List<PlayerPosts> postCount = _players.GroupBy(x => x.Position)
                                                  .Select(x => new PlayerPosts
                                                  {
                                                      PostName = x.Key,
                                                      PostCount = x.Count()
                                                  })
                                                  .ToList();

            // 7. kik azok a jatekosok (csak a nevuk) akik 90-es evekben szulettek
            List<string> playersBornIn90s = _players.Where(x => x.Birthday.StartsWith("199"))
                                                    .Select(x => x.Name)
                                                    .ToList();

            // 8. rendezzuk a jatekosokat csapatonkent
            List<PlayerTeams> playerCountByTeams = _players.GroupBy(x => x.Club)
                                                           .Select(x => new PlayerTeams
                                                           {
                                                               TeamName = x.Key,
                                                               PlayerNames = x.Select(x => x.Name).ToList(),
                                                           })
                                                           .ToList();

            foreach(PlayerTeams playerTeam in playerCountByTeams)
            {
                Console.WriteLine(playerTeam);
            }

        }
    }
}
