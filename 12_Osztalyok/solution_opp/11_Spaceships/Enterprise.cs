public class Enterprise : Spaceship, IHyperDrive
{
    public int FotonTorpedos { get; set; } = new Random().Next(10, 100);
    public override bool Attack(Spaceship spaceship)
    {
        Console.WriteLine($"Enterprise:\n - sebessege: {Speed}\n - ereje: {FotonTorpedos}");
        Console.WriteLine($"Ellenseg:\n - sebessege: {spaceship.Speed}\n - pajzs: {spaceship.Shield}");
        if (Speed >= spaceship.Speed)
        {
            if (FotonTorpedos > spaceship.Shield)
            {
                Console.WriteLine("bumbum");
                return true;
            }
            else
            {
                Console.WriteLine("gyenge");
                return false;
            }
        }
        else
        {
            Console.WriteLine("lassu");
            return false;
        }
    }

    public override void Selfdistruct()
    {
        Speed = 0;
        Shield = 0;
        Console.WriteLine("bum");
    }
    
    public void JumpToHyperSpeed() => Speed = Speed + 10;
}

