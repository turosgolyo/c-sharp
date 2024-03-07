internal class AbsentHoursByYear
{
    public string Year { get; set; }
    public int AbsentHours { get; set; }
    public override string ToString()
    {
        return $"{Year} {AbsentHours}";
    }
    public AbsentHoursByYear() { }
}