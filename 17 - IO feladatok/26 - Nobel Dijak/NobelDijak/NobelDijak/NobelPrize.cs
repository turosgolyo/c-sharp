namespace NobelDijak;

public class NobelPrize
{
    public int Year { get; set; }
    public string Type { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public NobelPrize(string row)
    {
        string[] parts = row.Split(';');
        Year = int.Parse(parts[0]);
        Type = parts[1];
        FirstName = parts[2];
        LastName = parts.Length > 3 ? parts[3] : "";
    }
}
