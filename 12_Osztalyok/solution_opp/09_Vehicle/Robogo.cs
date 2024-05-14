public class Robogo : Jarmu, IKisGepjarmu
{
    public int MaxSebesseg { get; set; }
    public Robogo(int aktualisSebesseg, string rendszam, int maxSebesseg) : base(aktualisSebesseg, rendszam)
    {
        this.MaxSebesseg = maxSebesseg;
    }

    public override bool GyorshajtottE(int sebessegkorlat) => sebessegkorlat < AktualisSebesseg;

    public bool HaladhatItt(int sebesseg) => sebesseg < MaxSebesseg;
    public override string ToString()
    {
        return $"Robogó: {base.ToString()}"; 
    }
}
