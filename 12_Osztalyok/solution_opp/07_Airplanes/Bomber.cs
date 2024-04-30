public class Bomber : Airplane
{
    public int Bombs { get; set; }
    public Bomber(string model, string type) : base(model, type)
    {
        this.Bombs = random.Next(1, 10);
    }
    public override void Attack()
    {
        if (this.Bombs == 0)
        {
            Console.WriteLine("Elfogyott a bomba!");
            return;
        }

        int droppedBombs = random.Next(1, this.Bombs + 1);
        Console.WriteLine($"{droppedBombs} bomba kioldva!");
        this.Bombs -= droppedBombs;
    }
}

