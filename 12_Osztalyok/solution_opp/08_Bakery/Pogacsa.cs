public class Pogacsa : Peksutemeny
{
    public Pogacsa(double mennyiseg, double alapar) : base(mennyiseg, alapar)
    {
    }

    public override double Megkostol() => this.Mennyiseg / 2;

    public override string ToString()
    {
        return $"Pogácsa {base.ToString()}";
    }
}

