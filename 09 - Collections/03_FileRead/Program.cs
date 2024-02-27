/*
A roplabda.txt állományban az adatok a következő módón vannak tárolva:
Név,
Magasság,
Poszt,
Nemzetiség,
Csapat,
Ország (ahol a csapat játszik)

1 - Írjuk ki a képernyőre az össz adatot
2 - Keressük ki az ütő játékosokat az utok.txt állömányba
3 - A csapattagok.txt állományba mentsük a csapatokat és a hozzájuk tartozó játékosokat a következő formában:
  Telekom Baku: Yelizaveta Mammadova, Yekaterina Gamova,
4 - Rendezzük a játékosokat magasság szerint növekvő sorrendbe és a magaslatok.txt állományba mentsük el.
5 - Mutassuk be a nemzetisegek.txt állományba, hogy mely nemzetiségek képviseltetik magukat a röplabdavilágban mint játékosok és milyen számban.
6 - atlagnalmagasabbak.txt állományba keressük azon játékosok nevét és magasságát akik magasabbak mint az „adatbázisban” szereplő játékosok átlagos magasságánál.
7 - Állítsa növekvő sorrendbe a posztok szerint a játékosok ösz magasságát
8 - Egy szöveges állományba, „alacsonyak.txt” keresse ki a játékosok átlagmagasságától alacsonyabb játékosokat. Az állomány tartalmazza a játékosok nevét, magasságát és hogy mennyivel alacsonyabbak az átlagnál, 2 tizedes pontossággal.
*/


// beolvasas, kiiras
List<Player> players = new List<Player>();

players = await FileService.ReadFromFileAsync("adatok.txt");

ExtendedSystem.WriteCollectionToConsole(players);

//uto jatekosok
List<Player> hittingPlayers = new List<Player>();
hittingPlayers = players.Where(x => x.Post == "ütõ").ToList();
await FileService.WriteToFileAsync("utok.txt", hittingPlayers);

//csapatonkent jatekosok
List<PlayersByTeam> playersByTeam= players.GroupBy(x => x.Team)
                            .Select(x => new PlayersByTeam
                            {
                                TeamName = x.Key,
                                Players = x.Select(x => x.Name).ToList()
                            }).ToList();

await FileService.WriteToFileAsync("csapattagok.txt", playersByTeam);

//sorba
List<Player> orderedPlayers = players.OrderBy(x => x.Height).ToList();
await FileService.WriteToFileAsync("magassagok.txt", orderedPlayers);

//nemzetisegek
List<PlayersByNation> playersByNation = players.GroupBy(x => x.Nationality)
                            .Select(x => new PlayersByNation
                            {
                                Nation = x.Key,
                                Names = x.Select(x => x.Name).ToList()
                            }).ToList();

await FileService.WriteToFileAsync("nemzetisegek.txt", playersByNation);

//atlag magasabbak
double averageHeight = players.Average(x => x.Height);
List<Player> tallerThanAverage = players.Where(x => x.Height > averageHeight).ToList();
await FileService.WriteToFileAsync("atlagnalmagasabbak.txt", tallerThanAverage);

//posztok szerint
List<Player> orderedByPost = players.OrderBy(x => x.Post).ThenBy(x => x.Height).ToList();

//atlagnal kisebbek
List<Player> shorterThanAverage = players.Where(x => x.Height < averageHeight).ToList();
await FileService.WriteToFileAsync("alacsonyak.txt", shorterThanAverage);