using System.Reflection;

public class RAMMemory : Hardware
{
    public int Capacity { get; set; }
    public int Frequency { get; set; }
    public RAMMemory()
    {
    }
    public RAMMemory(string manufacturer, string model, string type, int capacity, int frequency)
                : base(manufacturer, model, type)
    {
        Capacity = capacity;
        Frequency = frequency;
    }
}

