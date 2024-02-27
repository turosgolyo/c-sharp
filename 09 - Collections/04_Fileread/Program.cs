/*
A lotto.txt állományban az adatok a következő módón vannak tárolva:
Név	tippek

- Írjuk ki a képernyőre az össz adatot
- Random számok segítségével generáljuk le a napi 7 nyerő számot és írjuk őket egy szöveges állományba 
  melynek az aktuális nap lesz a neve
- Keressük ki, van(ak)-e 7 találatos szelvény(ek), ha igen írjuk ki a nyertesek nevét a nyertesek-{mai dátum}.txt állományba.
- Keressük ki, hogy a befizetett játékosok hány találatot értek el, és mentsük el a talalatok-{mai dátum}.txt állományba a játékos nevét és a találatainak számát
*/

// beolvasas, kiiras
using System.Security.Cryptography;

List<Lottery> people = new List<Lottery>();

people = await FileService.ReadFromFileAsync("adatok.txt");
ExtendedSystem.WriteCollectionToConsole(people);

//nyeroszamok
List<int> winningNumbers = new List<int>();
winningNumbers = GenerateWinningNumbers();
await FileService.WriteToFileAsync("nyeroszamok.txt", winningNumbers);

//nyertesek
List<Lottery> winners = new List<Lottery>();
winners = people.Where(x => x.Guesses.Intersect(winningNumbers).Count() == 7).ToList();
await FileService.WriteToFileAsync("nyertesek.txt", winners);

//talalatok
List<Hits> hits = new List<Hits>();
hits = people.Select(x => new Hits
{
    Name = x.Name,
    HitsCount = x.Guesses.Intersect(winningNumbers).Count()
}).ToList();
await FileService.WriteToFileAsync("talalatok.txt", hits);


static List<int> GenerateWinningNumbers()
{
    Random rnd = new Random();
    List<int> winningNumbers = new List<int>();
    do
    {
        int randomNumber = rnd.Next(1, 45);
        if (!winningNumbers.Contains(randomNumber))
        {
            winningNumbers.Add(randomNumber);
        }
        Thread.Sleep(100);
    }
    while (winningNumbers.Count <= 7);
    return winningNumbers;
}

