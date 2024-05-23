public class ForintBankszamla : Bankszamla, IBetet 
{
    public override double EgyenlegLekerese() => Egyenleg;

    public override void Fizetes(double osszeg)
    {
        Egyenleg -= osszeg;
        Egyenleg -= osszeg * 0.001;
    }

    public void Kamatozik() => Egyenleg = Egyenleg * 1.008;
}
