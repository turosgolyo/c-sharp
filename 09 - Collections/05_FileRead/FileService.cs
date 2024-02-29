using System.Collections.Generic;

public static class FileService
{
    #region File Read
    public static async Task<List<Volleyball>> ReadFromFileAsync(string fileName) 
    { 
        List<Volleyball> teams = new List<Volleyball>();
        Volleyball team = null;
        string[] data = null;
        string teamName = string.Empty;
        string points = string.Empty;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        while (!sr.EndOfStream)
        {
            teamName = await sr.ReadLineAsync();
            points = await sr.ReadLineAsync();

            data = points.Split(',');
            team = new Volleyball
            {
                Name = teamName,
                Points = data.Select(x => int.Parse(x.Trim())).ToList()
            };
            teams.Add(team);
        }


        return teams;
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
