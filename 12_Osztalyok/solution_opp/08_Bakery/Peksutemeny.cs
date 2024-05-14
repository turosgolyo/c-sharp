public abstract class Peksutemeny : IArlap
{
    public double Mennyiseg{ get; protected set; }
    
    private double alapar = 0;
    
    protected Peksutemeny(double mennyiseg, double alapar)
    {
        this.Mennyiseg = mennyiseg;
        this.alapar = alapar;
    }

    public double MennyibeKerul() => this.Mennyiseg * this.alapar;
    
    public abstract double Megkostol();
    
    public override string ToString()
    {
        return $"{Mennyiseg} sutemeny ara: {MennyibeKerul()} Ft";
    }
}
