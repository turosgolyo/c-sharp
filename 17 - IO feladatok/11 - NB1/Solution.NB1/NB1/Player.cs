namespace NB1;

public class Player
{
    public string ClubName { get; set; }
    public int Number { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsHungarian { get; set; }
    public bool IsForeign { get; set; }
    public int Worth { get; set; }
    public string Postion { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName} ({BirthDate})";
    }

}
