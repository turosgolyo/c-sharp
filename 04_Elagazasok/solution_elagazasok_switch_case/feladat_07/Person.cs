public class Person
{
    public string PersonName { get; set; }
    public int PersonAge { get; set; }
    public double PersonWeight { get; set; }
    public double PersonBenchPress { get; set; }

    public override string ToString()
    {
        return $"Név: {PersonName}\nÉletkor: {PersonAge} év\nSúly: {PersonWeight} kg\nFekvőnyomás: {PersonBenchPress} kg";
    }
}
