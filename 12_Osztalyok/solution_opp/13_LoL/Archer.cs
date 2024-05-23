public class Archer : Champion, IHide
{
    public Cast Cast { get; set; }

    public Archer(string name, Cast cast): base(name)
    {
        this.Cast = cast;
        SetStats();
    }

    public override void GetChill() => SetStats();

    public void Hide() => Power += 70;

    private void SetStats()
    {
        HP = rnd.Next(500, 650);
        Mana = rnd.Next(400, 500);
        Armor = rnd.Next(30, 50);
        MagicResistance = rnd.Next(30, 50);
        Power = rnd.Next(120, 280);
    }
}

