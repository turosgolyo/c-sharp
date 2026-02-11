namespace Tarsalgo;

public class DoorEvent
{
    public TimeSpan Time { get; set; }
    public int PersonId { get; set; }
    public bool IsEntry { get; set; } // true = in, false = out
}
