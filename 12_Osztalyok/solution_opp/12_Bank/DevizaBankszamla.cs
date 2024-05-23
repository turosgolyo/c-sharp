public class DevizaBankszamla : Bankszamla, IBetet
{
    public Deviza DevizaTipus { get; set; }
    public override double EgyenlegLekerese() => Egyenleg;

    public override void Fizetes(double osszeg)
    {
        Egyenleg -= osszeg;
        Egyenleg -= osszeg * 0.0015;
    }

    public void Kamatozik() => Egyenleg = Egyenleg* 1.0125;
}
