List<Book> books = await FileService.ReadFromFileAsync("adatok.txt");

books.WriteCollectionToConsole();

List<Book> itBooks = books.Where(x => x.Theme == "informatika").ToList();
await FileService.WriteToFileAsync("informatika", itBooks);

List<Book> booksReleasedIn1900s = books.Where(x => x.ReleaseDate >= 1900 && x.ReleaseDate < 2000).ToList();
await FileService.WriteToFileAsync("1900", booksReleasedIn1900s);

List<Book> orderedBooks = books.OrderByDescending(x => x.PageCount).ToList();
await FileService.WriteToFileAsync("sorbarakott", orderedBooks);

List<BookByTheme> booksByTheme = books.GroupBy(x => x.Theme)
                            .Select(x => new BookByTheme
                            {
                                Theme = x.Key,
                                Titles = x.Select(x => x.Title).ToList()
                            }).ToList();

await FileService.WriteToFileAsync("kategoriak", booksByTheme);
/*
 * A konyvek.txt állományban az adatok a következő módón vannak tárolva:

Vezetéknév (íróé),
Keresztnév (íróé),
SzületésiDátum,
Cím,
ISBN,
Kiadó,
KiadvasiÉv,
ár,
Téma,
Oldalszám,
Honorárium (amit a könyvért kapott az író)

Írjuk ki a képernyőre az össz adatot 😀
Keressük ki az informatika témajú könyveket és mentsük el őket az informatika.txt állömányba😁
Az 1900.txt állományba mentsük el azokat a könyveket amelyek az 1900-as években íródtak😎
Rendezzük az adatokat a könyvek oldalainak száma szerint csökkenő sorrendbe és a sorbarakott.txt állományba mentsük el.🤣
„kategoriak.txt” állományba mentse el a könyveket téma szerint. Például:
Thriller:
	- könnyv1
	- könnyv2
Krimi:
	- könnyv1
	- könnyv2
*/