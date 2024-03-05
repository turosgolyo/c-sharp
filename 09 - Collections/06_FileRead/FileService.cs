using System.Collections.Generic;

public static class FileService
{
    #region File Read
    public static async Task<List<Student>> ReadFromFileAsync(string fileName) 
    { 
        List<Student> students = new List<Student>();
        Student student = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF7);

        await sr.ReadLineAsync();

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();

            data = line.Split(";");

            student = new Student
            {
                Name = data[0],
                Year = data[1],
                FirstDay = int.Parse(data[2]),
                LastDay = int.Parse(data[3]),
                AbsentHours = int.Parse(data[4])
            };
            students.Add(student);
        }
        return students;
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
