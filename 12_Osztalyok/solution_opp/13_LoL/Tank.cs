
public class Tank : Champion, IRage
{
    public Cast Cast { get; set; }
    public string Clan { get; set; }

    public override void AttackChampion(Champion champion)
    {
        throw new NotImplementedException();
    }

    public void GoneMad()
    {
        throw new NotImplementedException();
    }
}

