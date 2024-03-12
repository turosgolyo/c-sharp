public class Pair
{

    public string GirlName { get; set; }
    public string BoyName { get; set; }
    public string Dance { get; set; }
    public Pair(string dance, string girlName, string boyName)
    {
        Dance = dance;
        GirlName = girlName;
        BoyName = boyName;
    }
    public Pair()
    {
    }
    public override string ToString()
    {
        return $"{Dance} - {GirlName} - {BoyName}";
    }
}
