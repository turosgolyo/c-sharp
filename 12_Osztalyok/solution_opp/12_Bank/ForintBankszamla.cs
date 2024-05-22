public class ForintBankszamla : Bankszamla, Betet 
{
    public override double EgyenlegLekerese() => Egyenleg;

    public override void Fizetes() => Egyenleg = Egyenleg * 0.999;

    public void Kamatozik() => Egyenleg = Egyenleg * 1.008;
}
