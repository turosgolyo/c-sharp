public abstract class Bosszuallo : ISzuperhos
{
    protected double Szuperero {  get; set; }
    
    protected bool VanEGyengesege { get; set; }

    public Bosszuallo(double szuperero, bool vanEGyengesege)
    {
        Szuperero = szuperero;
        VanEGyengesege = vanEGyengesege;
    }

    public abstract bool MegmentiAVilagot();

    public bool LegyoziE(ISzuperhos szuperhos)
    {
        if (szuperhos is Bosszuallo bosszuallo)
        {
            if (bosszuallo.VanEGyengesege == true && (bosszuallo.Szuperero > szuperhos.MekkoraAzEreje())) { return true; }
            else { return false; }
        }
        else
        {
            if (Szuperero/2 < szuperhos.MekkoraAzEreje()) { return true; }
            else { return false; }
        }
    }

    public double MekkoraAzEreje() => Szuperero;

    public override string ToString()
    {
        return $"ereje {Szuperero}, {(VanEGyengesege ? "nincs" : "van")} gyengesége.";
    }
}
