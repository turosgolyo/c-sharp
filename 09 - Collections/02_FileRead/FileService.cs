internal class FileService
{
    #region File Read
    public static async Task<List<Book>> ReadFromFileAsync(string fileName)
    { 
        List<Book> books = new List<Book>();
        Book book = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            
            data = line.Split("\t");

            book = new Book
            {
                FirstName = data[0],
                LastName = data[1],
                BirthDate = data[2],
                Title = data[3],
                ISBN = data[4],
                Publisher = data[5],
                ReleaseDate = int.Parse(data[6]),
                Price = int.Parse(data[7]),
                Theme = data[8],
                PageCount = int.Parse(data[9])
            };
            books.Add(book);
        }

        return books;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileAsync(string fileName, ICollection<Book> books)
    {
        Directory.CreateDirectory("output");

        string path = Path.Combine("output", $"{fileName}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach(Book book in books)
        {
            await sw.WriteLineAsync($"{book.Title}\t{book.Theme}\t{book.ReleaseDate}");
        }
    }
    #endregion
}
