public class Mage : Champion, ICast
{
    public Cast Cast { get; set; }
    public string Guild { get; set; }
    public override void AttackChampion(Champion champion)
    {
        throw new NotImplementedException();
    }

    public void HokusPokus()
    {
        throw new NotImplementedException();
    }
}
