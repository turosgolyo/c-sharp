public class DevizaBankszamla : Bankszamla, Betet
{
    public Deviza DevizaTipus { get; set; }
    public override double EgyenlegLekerese() => Egyenleg;

    public override void Fizetes() => Egyenleg = Egyenleg * 0.9985;

    public void Kamatozik() => Egyenleg = Egyenleg* 1.0125;
}
