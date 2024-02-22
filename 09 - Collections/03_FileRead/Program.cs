﻿/*
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
using static System.Reflection.Metadata.BlobBuilder;

List<Player> players = new List<Player>();

players = await FileService.ReadFromFileAsync("adatok.txt");

ExtendedSystem.WriteCollectionToConsole(players);

//uto jatekosok, nem mukszik 
List<Player> hittingPlayers = new List<Player>();
hittingPlayers = players.Where(x => x.Post == "uto").ToList();
await FileService.WriteToFileAsync("utok.txt", hittingPlayers);

//csapatonkent jatekosok
List<PlayersByTeam> playersByTeam= players.GroupBy(x => x.Team)
                            .Select(x => new PlayersByTeam
                            {
                                TeamName = x.Key,
                                Players = x.Select(x => x.Name).ToList()
                            }).ToList();

await FileService.WriteToFileAsync("csapattagok.txt", playersByTeam);