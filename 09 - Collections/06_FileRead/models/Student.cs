public class Student
{
    public string Name { get; set; }
    public string Year { get; set; }
    public int FirstDay { get; set; }
    public int LastDay { get; set; }
    public int AbsentHours { get; set; }
    public Student(string name, string year, int firstDay, int lastDay, int absentHours)
    {
        Name = name;
        Year = year;
        FirstDay = firstDay;
        LastDay = lastDay;
        AbsentHours = absentHours;
    }
    public Student() { }
    public override string ToString()
    {
        return $"{Name} {Year} {FirstDay} {LastDay} {AbsentHours}";
    }
}
