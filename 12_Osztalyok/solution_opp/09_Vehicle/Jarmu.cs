public abstract class Jarmu
{
    public int AktualisSebesseg { get; set; }
    
    private string rendszam;

    public Jarmu(int aktualisSebesseg, string rendszam)
    {
        this.AktualisSebesseg = aktualisSebesseg;
        this.rendszam = rendszam;
    }

    public abstract bool GyorshajtottE(int sebessegkorlat);

    public override string ToString()
    {
        return $"{this.rendszam} - {this.AktualisSebesseg} km/h";
    }
}
