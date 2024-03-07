public static class FileService
{
    #region File Read
    public static async Task<List<Player>> ReadFromFileAsync(string fileName) 
    { 
        List<Player> players = new List<Player>();
        Player player = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF7);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();

            data = line.Split(';');
            player = new Player
            {
                Name = data[0],
                First = DateTime.Parse(data[1]),
                Last = DateTime.Parse(data[2]),
                Weight = int.Parse(data[3]),
                Height = int.Parse(data[4])
            };
            players.Add(player);
        }


        return players;
    }
    #endregion
    #region File Write
    public static async Task WriteToFileAsync<T>(string fileName, ICollection<T> collection)
    {
        Directory.CreateDirectory("output");

        string path = Path.Combine("output", fileName);

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (T item in collection)
        {
            await sw.WriteLineAsync($"{item}");
        }
    }
    #endregion
}
