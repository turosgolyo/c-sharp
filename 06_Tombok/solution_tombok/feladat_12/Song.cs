public class Song
{
    public string Name { get; set; }
    public int Number { get; set; }
    public int Length { get; set; }

    public int Min => Length / 60;
    public int Sec => Length % 60;
    
    public Song(string name, int number, int length)
    {
        Name = name;
        Number = number;
        Length = length;
    }
    public override string ToString()
    {
        return $"{Number}. {Name} - ({Min}:{Sec.ToString().PadLeft(2, '0')} - {Length}s)";
    }
}