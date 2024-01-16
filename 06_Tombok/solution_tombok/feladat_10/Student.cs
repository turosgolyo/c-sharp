public class Student
{
    public string Name { get; set; }
    public int Saving { get; set; }
    public Student(string name, int saving)
    {
        Name = name;
        Saving = saving;
    }
    public override string ToString()
    {
        return $"Tanuló neve: {Name} - Megtakarítás: {Saving}";
    }
}
