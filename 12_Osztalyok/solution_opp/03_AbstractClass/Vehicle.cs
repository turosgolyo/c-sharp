
public class Vehicle
{
    // az orokolt osztalyokban feluldefinialhato
    public virtual void Horn()
    {
        Console.Beep(1000, 800);
    }
    public abstract void Error()
    {

    }
}
