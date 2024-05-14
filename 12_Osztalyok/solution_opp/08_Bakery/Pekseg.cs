using System.Text;

public class Pekseg
{
    private static List<IArlap> aruk = new List<IArlap>();

    public static async Task VasarlokAsync(string fileName)
    {
        foreach(string line in await File.ReadAllLinesAsync(fileName, Encoding.UTF8))
        {
            string[] data = line.Split(' ');

            IArlap aru = PeksutemenyFactory.AruEloallitasa(data);

            aruk.Add(aru);
        }
    }

    public static async Task EtelLeltarAsync()
    {
        try
        {
            IEnumerable<string?> pogacsak = aruk.Where(x => x.GetType() == typeof(Pogacsa))
                                            .Select(x => x.ToString());

            await File.WriteAllLinesAsync("leltar.txt", pogacsak);
        }
        catch(Exception ex)
        {
            throw new Exception("leltar.txt letrehozasa nem sikerult");
        }
        
    }
}

