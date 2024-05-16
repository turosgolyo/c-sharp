public class AudiS8 : Jarmu
{
    public bool LezerBlokkolo { get; set; }
    public AudiS8(int aktualisSebesseg, string rendszam, bool lezerBlokkolo) : base(aktualisSebesseg, rendszam)
    {
        LezerBlokkolo = lezerBlokkolo;
    }

    public override bool GyorshajtottE(int sebessegkorlat)
    {
        if(LezerBlokkolo == false)
        {
            return false;
        }
        else if(AktualisSebesseg > sebessegkorlat)
        {
            return true;
        }
    }
}
