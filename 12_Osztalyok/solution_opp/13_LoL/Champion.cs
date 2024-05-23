using System.Formats.Tar;

public abstract class Champion : IChill
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int HP { get; set; }
    public int Mana { get; set; }
    public int Armor { get; set; }
    public int MagicResistance { get; set; }

    protected Random rnd = new Random();

    protected Champion(string name)
    {
        this.Name = name;
    }

    public bool AttackChampion(Champion champion) => ;

    public abstract void GetChill();
}
