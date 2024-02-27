using System.Collections.Generic;

public static class FileService
{
    #region File Read
    public static async Task<List<Lottery>> ReadFromFileAsync(string fileName) 
    { 
        List<Lottery> people = new List<Lottery>();
        Lottery person = null;
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

            person = new Lottery
            {
                Name = data[0],
                Guesses = data[1].Split(',').Select(x => int.Parse(x)).ToList()
            };
            people.Add(person);
        }
        return people;
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
