public static class PeksutemenyFactory
{
    public static IArlap AruEloallitasa(string[] data)
    {
        string tipus = data.First();

        return tipus switch
        {
            "Pogacsa" => new Pogacsa(double.Parse(data[1]), double.Parse(data[2])),
            "Kave" => new Kave(data[1] == "habos")
        };
    }
} 
