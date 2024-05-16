public class Batman : ISzuperhos, IMilliardos
{
    public Batman(double lelemenyesseg = 100)
    {
        Lelemenyesseg = lelemenyesseg;
    }

    public double Lelemenyesseg { get; set; }
    
    public void KutyutKeszit() => Lelemenyesseg = Lelemenyesseg + 50;

    public bool LegyoziE(ISzuperhos szuperhos)
    {
        if (Lelemenyesseg > (szuperhos.MekkoraAzEreje()/2)) { return true; }
        else { return false; }
    }

    public double MekkoraAzEreje() => Lelemenyesseg * 2;
}
