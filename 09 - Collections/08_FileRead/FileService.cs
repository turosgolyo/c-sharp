public static class FileService
{
    #region File Read
    public static async Task<List<Pair>> ReadFromFileAsync(string fileName) 
    { 
        List<Pair> pairs = new List<Pair>();
        Pair pair = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF7);

        while (!sr.EndOfStream)
        {
            pair = new Pair
            {
                Dance = await sr.ReadLineAsync(),
                GirlName = await sr.ReadLineAsync(),
                BoyName = await sr.ReadLineAsync()
            };
            pairs.Add(pair);
        }
        return pairs;
    }
    #endregion
    #region File Write
    public static async Task WriteToFileAsync<T>(string fileName, ICollection<T> firstCollection, ICollection<T> secondCollection)
    {
        Directory.CreateDirectory("output");

        string path = Path.Combine("output", fileName);

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        await sw.WriteAsync($"\nFiuk: ");
        foreach (T item in firstCollection)
        {
            await sw.WriteAsync($"{item} ");
        }

        await sw.WriteAsync($"\nLanyok: ");
        foreach (T item in secondCollection)
        {
            await sw.WriteAsync($"{item} ");
        }
    }
    #endregion
}
