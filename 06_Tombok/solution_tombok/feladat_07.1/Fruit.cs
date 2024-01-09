public class Fruit
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public int UnitPrice { get; set; }
    public int Price
    {
        get
        {
            return Amount * UnitPrice;
        }
    }
    public Fruit(string name, int amount, int unitPrice)
    {
        Name = name;
        Amount = amount;
        UnitPrice = unitPrice; 
    }
    public override string ToString()
    {
        return $"{Name} - {Amount} kg - {UnitPrice} Ft/kg - {Price} Ft";
    }
}
