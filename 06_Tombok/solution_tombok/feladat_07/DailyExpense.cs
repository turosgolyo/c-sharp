public class DailyExpense
{
    public Day Day { get; set; }

    public int Expense { get; set; }

    public DailyExpense()
    {
    }
    
    public DailyExpense(Days day, int expense)
    {
        this.Day = day;
        this.Expense = expense;
    }
    
    public override string ToString()
    {
        return $"{this.Day} => {this.Expense}";
        
    }
}
