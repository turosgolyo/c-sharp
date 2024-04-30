public abstract class Airplane : IAirplane
{
    public string Model { get; protected set; }
    public string Type { get; protected set; }
    public int Speed { get; protected set; }
    
    protected Random random = new Random();
    protected Airplane(string model, string type) 
    {
        this.Model = model;
        this.Type = type;
        this.Speed = random.Next(100, 1000);
    }
    public abstract void Attack();
}

