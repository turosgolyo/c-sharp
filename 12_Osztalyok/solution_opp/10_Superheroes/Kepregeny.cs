using System.Text;

public static class Kepregeny
{
    public static async Task SzereplokAsync(string fileName)
    {
        foreach (string line in await File.ReadAllLinesAsync(fileName, Encoding.UTF8))
        {
            string[] data = line.Split(' ');
            
            string tipus;

            tipus = data[0] switch
            {
                "Vasember" => 
                "Batman" => 
            };
        }
    }
    public static async Task SzuperhosokAsync()
    {

    }
}
