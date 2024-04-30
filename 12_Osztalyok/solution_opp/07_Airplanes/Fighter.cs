public class Fighter : Airplane
{
    public int Rockets { get; set; }
    public Fighter(string model, string type) : base(model, type)
    {
        this.Rockets = random.Next(1, 10);
    }
    public override void Attack()
    {
        if (this.Rockets == 0)
        {
            Console.WriteLine("Elfogyott a rakéta!");
            return;
        }

        Console.WriteLine("Rakéta kilőve!");
        this.Rockets--;
    }
}

