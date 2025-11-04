namespace Solution.Volleyball;

public class Player
{
    public string Name { get; set; }
    public int Height { get; set; }
    public string Position { get; set; }
    public string Nationality { get; set; }
    public string Team { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Team}";
    }
    public string ToNameHeightString()
    {
        return $"{Name} - {Height}";
    }
    public string ToShorterThanAverageString(double average)
    {
        return $"{Name} - {Height} - {Math.Round((average - Height), 2)}";
    }
    public string ToFullString()
    {
        return $"{Name}\t{Height}\t{Position}\t{Nationality}\t{Team}\t{Country}";
    }
}
