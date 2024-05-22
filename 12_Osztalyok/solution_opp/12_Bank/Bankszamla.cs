public abstract class Bankszamla
{
    public int Id { get; set; }
    public Tulajdonos Tulajdonos { get; set; }
    public string Szamlaszam { get; set; }
    public double Egyenleg { get; set; }
    public abstract void Fizetes();
    public abstract double EgyenlegLekerese();
}
