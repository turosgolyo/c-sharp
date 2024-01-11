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
        this.Name = name;
        this.Amount = amount;
        this.UnitPrice = unitPrice;
    }
    public override string ToString()
    {
        return $"{this.Name} - {this.Amount} kg - {this.UnitPrice} Ft/kg - {this.Price} Ft";
    }

}
