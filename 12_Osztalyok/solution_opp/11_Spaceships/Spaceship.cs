public abstract class Spaceship
{
    public string Name { get; set; }
    public Captain Captain { get; set; }
    public int Speed { get; set; } = new Random().Next(100, 200);
    public int Shield { get; set; }
    public abstract bool Attack(Spaceship spaceship);
    public abstract void Selfdistruct();
}

